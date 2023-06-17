namespace BankStatCore.Models;

public class CurrencyModel
{
    //Id валюты
    public string Id { get; set; }
    //Валюта: BYN, USD, EUR, RUB
    public string Iso { get; set; }
}