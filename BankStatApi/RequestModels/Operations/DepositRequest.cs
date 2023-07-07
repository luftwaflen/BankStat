namespace BankStatApi.RequestModels.Operations;

public class DepositRequest
{
    public string Id { get; set; }

    //Получатель
    public string ReceiverId { get; set; }

    //Сумма операции
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
}