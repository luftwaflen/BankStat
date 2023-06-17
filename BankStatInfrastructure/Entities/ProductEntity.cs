namespace BankStatInfrastructure.Entities;

public class ProductEntity
{
    //ID продукта
    public string Id { get; set; }

    //Тип продукта: account, deposit, card, credit
    public string Type { get; set; }

    //Информация о продукте
    public ProductInfoEntity ProductInfo { get; set; }
}