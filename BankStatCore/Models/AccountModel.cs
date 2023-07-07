namespace BankStatCore.Models;

public class AccountModel
{
    //Id счета
    public string Id { get; set; }

    //Имя/номер  счета
    public string Name { get; set; }

    //Баланс и валюта счета
    public decimal Amount { get; set; }
    public virtual CurrencyModel Currency { get; set; }
    
    //Владелец счета
    public virtual UserModel User { get; set; }
}