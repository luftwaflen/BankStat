namespace BankStatCore.Models
{
    public class ProductInfoModel
    {
        public string Id { get; set; }
        //Имя продукта
        public string ProductId { get; set; }
        //Модель продукта
        public ProductModel Product { get; set; }
        //Номер счета
        public string AccountId { get; set; }
        //Модель счета
        public AccountModel Account { get; set; }
        public AmountModel Amount { get; set; }
    }
}
