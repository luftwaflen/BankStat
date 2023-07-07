namespace BankStatApi.ResponseModels;

public class AccountResponce
{
    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
    public string UserLogin { get; set; }
}