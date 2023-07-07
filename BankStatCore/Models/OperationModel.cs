namespace BankStatCore.Models;

public class OperationModel
{
    public string Id { get; set; }

    //Отправитель
    public virtual AccountModel Sender { get; set; }

    //Получатель
    public virtual AccountModel Receiver { get; set; }

    //Сумма операции
    public decimal Amount { get; set; }
    public virtual CurrencyModel Currency { get; set; }

    //Тип операции
    public string Type { get; set; }
}