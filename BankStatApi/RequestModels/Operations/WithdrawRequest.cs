namespace BankStatApi.RequestModels.Operations;

public class WithdrawRequest
{
    public string Id { get; set; }

    //Получатель
    public string ReceiverId { get; set; }

    //Сумма операции
    public decimal Amount { get; set; }
    public string CurIso { get; set; }
}