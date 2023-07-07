namespace BankStatAlphaBankIntegration.Models.Requests;

public class AlphaExchangeRequest
{
    public string CurrPair { get; set; }
    public bool AmountType { get; set; }
    public decimal Amount { get; set; }
    public string NumberBuy { get; set; }
    public string NumberSell { get; set; }
    public DateOnly SettlementDate { get; set; }
}