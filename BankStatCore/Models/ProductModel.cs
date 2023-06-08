namespace BankStatCore.Models
{
    public class ProductModel
    {
        //ID продукта
        public string Id { get; set; }
        //Тип продукта: account, deposit, card, credit
        public string Type { get; set; }
        //Информация о продукте
        public ProductInfoModel Info { get; set; }
    }
}
