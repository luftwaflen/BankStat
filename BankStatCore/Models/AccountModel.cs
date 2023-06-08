namespace BankStatCore.Models
{
    public class AccountModel
    {
        //ID счета
        public string Id { get; set; }
        //Имя/номер  счета
        public string Name { get; set; }
        //Текущий баланс и валюта счета
        public AmountModel Amount { get; set; }
    }
}
