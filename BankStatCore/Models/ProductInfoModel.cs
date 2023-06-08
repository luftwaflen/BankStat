namespace BankStatCore.Models
{
    public class ProductInfoModel
    {
        //Имя продукта
        public string Title { get; set; }
        //Номер счета или номер карты с маской
        public string Number { get; set; }
        //
        public AmountModel Amount { get; set; }
    }
}
