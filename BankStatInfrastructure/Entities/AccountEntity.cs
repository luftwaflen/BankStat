namespace BankStatInfrastructure.Entities;

public class AccountEntity
{
    //ID счета
    public string Id { get; set; }
    //Имя/номер  счета
    public string Name { get; set; }
    //Баланс счета
    public decimal Amount { get; set; }
    //
    public UserEntity User { get; set; }
    //Id валюты счета
    public CurrencyEntity Currency { get; set; }    
    //public IEnumerable<OperationEntity> Operations { get; set; }
}