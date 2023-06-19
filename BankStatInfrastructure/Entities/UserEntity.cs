namespace BankStatInfrastructure.Entities;

public class UserEntity
{
    public string Id { get; set; }

    //Логин
    public string Login { get; set; }

    //Пароль
    public string Password { get; set; }

    //Счета пользователя
    public IEnumerable<AccountEntity> Accounts { get; set; }
}