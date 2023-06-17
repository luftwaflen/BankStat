namespace BankStatCore.Models;

public class ProductInfoModel
{
    //Продукт
    public ProductModel Product { get; set; }
    //Счет
    public AccountModel Account { get; set; }
    //Стоимость и валюта
    public AmountModel Amount { get; set; }
}