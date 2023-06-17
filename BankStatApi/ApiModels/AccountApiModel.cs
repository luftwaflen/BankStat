namespace BankStatApi.ApiModels;

public class AccountApiModel
{
    public string Id { get; set; }

    //Имя/номер  счета
    public string Name { get; set; }

    //Баланс и валюта счета
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
}