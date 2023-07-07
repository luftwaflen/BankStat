namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaAccountDetails
{
    public string Number { get; set; }
    public string Type { get; set; }
    public bool IsCard { get; set; }
    public int CurrCode { get; set; }
    public int CurrIso { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountAvailable { get; set; }
    public int ActiveCards { get; set; }
    public decimal CatalogAmountRest { get; set; }
    public decimal OverdraftAmount { get; set; }
    public decimal OverdraftLimit { get; set; }
    public decimal ReservedAmount { get; set; }
    public string ArrestInfo { get; set; }
    public decimal ArrestAmount { get; set; }
    public DateTime ActualBalanceDate { get; set; }
    public decimal DocAmount { get; set; }
}