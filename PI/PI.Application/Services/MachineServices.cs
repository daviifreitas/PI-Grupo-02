using PI.Application.Intefaces;
using PI.Application.ViewModel.Machine;
using PI.Domain.Entities;
using PI.Domain.Interfaces;

namespace PI.Application.Services;

public class MachineServices : IMachineService
{
    private readonly IMachineRepository _machineRepository;
    private readonly IEnterpriseRepository _enterpriseRepository;
    private readonly ILogsRepository _logRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMachineStatusRepository _machineStatusRepository;

    public MachineServices(IMachineRepository machineRepository, IEnterpriseRepository enterpriseRepository, ILogsRepository logRepository, ICategoryRepository categoryRepository, IMachineStatusRepository machineStatusRepository)
    {
        _machineRepository = machineRepository;
        _enterpriseRepository = enterpriseRepository;
        _logRepository = logRepository;
        _categoryRepository = categoryRepository;
        _machineStatusRepository = machineStatusRepository;
    }

    public async Task<List<MachinesForListViewModel>> GetAll(int enterpriseId)
    {
        bool any = _enterpriseRepository.GetAll().Any(enterprise => enterprise.Id == enterpriseId);

        if (any)
        {
            IEnumerable<Log> logs = _logRepository.GetAll();

            IEnumerable<Machine> machines = _machineRepository.GetAll().Where(machine => machine.Enterprise.Id == enterpriseId);

            List<MachinesForListViewModel> machinesforView = new List<MachinesForListViewModel>();

            foreach (var machine in machines)
            {
                DateTime dateTime = logs.Where(log => log.Machine.Id == machine.Id).Max(log => log.Created_at);

                Log logOfMachine = _logRepository.GetAll()
                    .Where(log => log.Machine.Id == machine.Id && log.Created_at == dateTime).FirstOrDefault();
                
                machinesforView.Add(new MachinesForListViewModel()
                {
                    Id = machine.Id ,
                    Brand = machine.Brand ,
                    Model = machine.Model , 
                    SerialNumber = machine.SerialNumber , 
                    Status = machine.Status.Name,
                    Noise = logOfMachine.Noise , 
                    Temp = logOfMachine.Temp ,
                    Vibration = logOfMachine.Vibration,
                    category = machine.Category.Name
                });
            }

            return machinesforView;
        }

        return new List<MachinesForListViewModel>();

    }

    public async Task<List<MachinesForListViewModel>> GetMachinesForSpecificCategory(int enterpriseId, string categoryName)
    {
        List<MachinesForListViewModel> task = await GetAll(enterpriseId);

        List<MachinesForListViewModel> machinesWithCateogry = new List<MachinesForListViewModel>();
        
        foreach (var machine in task)
        {
            if (machine.category == categoryName)
            {
                machinesWithCateogry.Add(machine);
            }
        }

        return machinesWithCateogry;
    }

    public async Task<bool> CreateNewMachine(AddMachineViewModel model)
    {
        Machine byId = _machineRepository.GetById(model.Id);

        if (byId != null) return false;

        Machine machineForAddInDb = new Machine()
        {
            Brand = model.Brand,
            Id = model.Id,
            Category = AddCategoryInMachine(model.Category),
            TempMax = model.MaxTemp,
            TempMim = model.MimTemp,
            NoiseMax = model.MaxNoise,
            NoiseMin = model.MimNoise,
            VibrationMax = model.MaxVibration,
            VibrationMin = model.MimVibration,
            Created_at = DateTime.Now,
            Status = AddStatusInMachine(model.Status),
            Enterprise = _enterpriseRepository.GetById(model.EnterpriseId), 
            Location = model.Location 
        }; 
        
        _machineRepository.Add(machineForAddInDb);

        return true; 
    }

    private MachineStatus AddStatusInMachine(string modelStatus)
    {
        MachineStatus? firstOrDefault = _machineStatusRepository.GetAll().FirstOrDefault(machineStatus => machineStatus.Name == modelStatus);

        return firstOrDefault;
    }

    private Category AddCategoryInMachine(string modelCategory)
    {
        Category byName = _categoryRepository.GetByName(modelCategory);
        return byName;
    }
} 
