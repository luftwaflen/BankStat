namespace BankStatApi.RequestModels;

public class AccountRequest
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
}