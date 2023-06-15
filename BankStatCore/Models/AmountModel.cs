namespace BankStatCore.Models;

public class AmountModel
{
    //Сумма
    public decimal Amount { get; set; }
    //Валюта: BYN, USD, EUR, RUB
    public string CurrIso { get; set; }
}