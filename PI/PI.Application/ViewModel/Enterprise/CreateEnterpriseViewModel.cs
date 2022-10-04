namespace PI.Application.ViewModel.Enterprise;

public class CreateEnterpriseViewModel
{
    public int Id { get; set; }
    public string CNPJ { get; set; }
    public string SocialReason { get; set; }
    public string FantasyName { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int NumberOfLocation { get; set; }
    public string Sector { get; set; }

    public CreateEnterpriseViewModel()
    {
        Id = new Random().Next(10000, 1000000);
    }
}