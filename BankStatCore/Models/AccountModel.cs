namespace BankStatCore.Models;

public class AccountModel
{
    //Id счета
    public string Id { get; set; }
    //Имя/номер  счета
    public string Name { get; set; }
    //Баланс и валюта счета
    public AmountModel Amount { get; set; }
}