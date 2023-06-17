namespace BankStatCore.Models;

public class UserModel
{
    public string Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public IEnumerable<AccountModel> Accounts { get; set; }
}
