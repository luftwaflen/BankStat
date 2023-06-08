namespace BankStatCore.Models
{
    public class AmountModel
    {
        public string Id { get; set; }
        //Сумма. Null или не передаётся, если для объекта не отображается сумма
        public decimal Amount { get; set; }
        //Валюта: BYN, USD, EUR, RUB
        public string CurrIso { get; set; }
    }
}
