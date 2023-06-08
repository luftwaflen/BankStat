namespace BankStatCore.Models
{
    //Выходная модель, содержащая историю операций
    public class DescResponse
    {
        //Общее количество найденных элементов
        public int TotalRowCount { get; set; }
        //ID счета, использованного при поиске, в случае, если в поиске использовался счет
        public string FilterAccount { get; set; }
        //Счета
        public List<AccountModel> Accounts { get; set; }
        //Минимальное значение суммы транзакции
        public decimal MinAmount { get; set; }
        //Максимальное значение суммы транзакции
        public decimal MaxAmount { get; set; }
        //Минимальное значение даты для фильтра в формате yyyy-MM-dd’T’HH:mm:ss
        public DateTime DateForm { get; set; }
        //Максимальное значение даты для фильтра в формате yyyy-MM-dd’T’HH:mm:ss
        public DateTime DateTo { get; set; }
        //Операции
        public List<OperationModel> Items { get; set; }
    }
}
