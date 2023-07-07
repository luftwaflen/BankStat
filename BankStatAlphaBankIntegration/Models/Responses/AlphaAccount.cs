namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaAccount
{
    public string Number { get; set; }
    public string Type { get; set; }
    public bool IsCard { get; set; }
    public int CurrCode { get; set; }
    public string CurrIso { get; set; }
    public decimal Amount { get; set; }
    public bool? IsOverdraft { get; set; }
    public bool? IsReserved { get; set; }
    public bool? IsCatalog { get; set; }
    public bool? IsArrested { get; set; }
    public DateTime ActualBalanceDate { get; set; }
    public decimal? DocAmount { get; set; }
}