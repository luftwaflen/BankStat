namespace BankStatCore.Models
{
    public class ShortErrorModel
    {
        //Категория ошибки
        public string Category { get; set; }
        //Код ошибки
        public int Code { get; set; }
        //Сообщение об ошибке
        public string Message { get; set; }
    }
}