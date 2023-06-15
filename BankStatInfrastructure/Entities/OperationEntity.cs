namespace BankStatInfrastructure.Entities;

public class OperationEntity
{
    //ID операции
    public string Id { get; set; }
    public AccountEntity Sender { get; set; }
    public AccountEntity Receiver { get; set; }
    //Сумма операции
    public decimal Amount { get; set; }
    //Валюта операции
    public CurrencyEntity Currency { get; set; }
    //Тип операции
    public string Type { get; set; }
}