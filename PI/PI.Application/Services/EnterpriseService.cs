using PI.Application.Intefaces;
using PI.Application.ViewModel.Enterprise;
using PI.Domain.Entities;
using PI.Domain.Interfaces;

namespace PI.Application.Services;

public class EnterpriseService : IEnterpriseService
{
    private readonly IEnterpriseRepository _enterpriseRepository;

    public EnterpriseService(IEnterpriseRepository enterpriseRepository)
    {
        _enterpriseRepository = enterpriseRepository;
    }

    public async Task<bool> Login(EnterpriseLoginViewModel model )
    {
        IEnumerable<Enterprise> enterprises = _enterpriseRepository.GetAll();

        bool isInDb = enterprises.Any(enterprise => enterprise.Cnpj == model.Login && enterprise.Password == model.Password && enterprise.EnterpriseStatus.Name == "ACTIVE");

        return isInDb;
    }
    
    
}