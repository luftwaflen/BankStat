namespace BankStatInfrastructure.Entities;
public class UserEntity
{
    public string Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public IEnumerable<AccountEntity> Accounts { get; set; }
}