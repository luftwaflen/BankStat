namespace BankStatApi.ApiModels;

public class OperationApiModel
{
    public string Id { get; set; }
    //Отправитель
    public string SenderId { get; set; }
    //Получатель
    public string ReceiverId { get; set; }
    //Сумма операции
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
    //Тип операции
    public string Type { get; set; }
}