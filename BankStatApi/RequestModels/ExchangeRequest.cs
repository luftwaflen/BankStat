namespace BankStatApi.RequestModels;

public class ExchangeRequest
{
    public decimal Amount { get; set; }
    public string CurrencyBase { get; set; }
    public string CurrencyExchange { get; set; }
}