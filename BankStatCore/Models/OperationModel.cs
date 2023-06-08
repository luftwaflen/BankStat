namespace BankStatCore.Models
{
    public class OperationModel
    {
        //ID операции
        public string Id { get; set; }
        //Наименование получателя
        public string Title { get; set; }
        //
        public AmountModel Amount { get; set; }
        //Дата операции
        public DateTime Date { get; set; }
        //Описание операции.Передаётся в виде текста с разделителями строк
        public string Description { get; set; }
        //
        public AmountModel OperationAmount { get; set; }
        //Маска карты - источника в формате X…XXXX(пусто если карта не указана)
        public string CardMask { get; set; }
        //Статус операции: normal, rejected, hold
        public string Status { get; set; }
        //IBAN счёта для отображения деталей записи истории
        public string Number { get; set; }
        //Тип операции для случаев, где необходимо определение типа операций
        public string OperationType { get; set; }
        /*
         * payment- платёж ЕРИП
         * ownAccountsTransfer - перевод между своими счетами
         * personTransfer - перевод физ.лицу
         * personTransferAbb - перевод физлицу в пределах банка
         * companyTransfer - перевод юр. лицу
         * currencyExchange - обмен валюты
         * depositTransfer - пополнение депозита
         * creditCardTransfer - пополнение кредитной карты,
         * creditTransfer - оплата кредита
         */
    }
}
