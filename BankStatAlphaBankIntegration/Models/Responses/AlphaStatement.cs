namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaStatement
{
    public string Number { get; set; }
    public string OperType { get; set; }
    public int OperCode { get; set; }
    public string OperCodeName { get; set; }
    public DateOnly OperDate { get; set; }
    public DateTime AcceptDate { get; set; }
    public string DocId { get; set; }
    public string DocNum { get; set; }
    public string DocType { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountEq { get; set; }
    public int CurrCode { get; set; }
    public string CurrIso { get; set; }
    public string Purpose { get; set; }
    public string CorrName { get; set; }
    public string CorrNumber { get; set; }
    public string CorrBic { get; set; }
    public string CorrBank { get; set; }
    public string BudgetCode { get; set; }
    public string PrintId { get; set; }
    public string UnpThird { get; set; }
    public string RealRate { get; set; }
    public string SumPaymentInstruction { get; set; }
    public int HasCard { get; set; }
    public string CardMask { get; set; }
    public string CardHolder { get; set; }
    public int HasCheque { get; set; }
    public int HasSwift { get; set; }
    public string SumFee { get; set; }
    public string CurrencyFee { get; set; }
}