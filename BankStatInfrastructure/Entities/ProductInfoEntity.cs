namespace BankStatInfrastructure.Entities;

public class ProductInfoEntity
{
    //Счет
    public AccountEntity Account { get; set; }
    //Баланс счета
    public decimal Amount { get; set; }
    //Валюта счета
    public CurrencyEntity Currency { get; set; }
}