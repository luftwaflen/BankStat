namespace BankStatCore.Models;

public class OperationModel
{
    public string Id { get; set; }
    //Отправитель
    public AccountModel Sender { get; set; }
    //Получатель
    public AccountModel Receiver { get; set; }
    //Сумма операции
    public AmountModel OperationAmount { get; set; }
    //Тип операции
    public string Type { get; set; }
}