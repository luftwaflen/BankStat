namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaRate
{
    public string CurrPair { get; set; }
    public decimal Rate { get; set; }
    public string SellIso { get; set; }
    public int SellCode { get; set; }
    public string BuyIso { get; set; }
    public int BuyCode { get; set; }
    public int Quanity { get; set; }
    public int RateType { get; set; }
}