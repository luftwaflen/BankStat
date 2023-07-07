namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaStatementStatistics
{
    public string Number { get; set; }
    public decimal OpeningBalance { get; set; }
    public decimal OpeningBalanceEq { get; set; }
    public decimal ClosingBalance { get; set; }
    public decimal ClosingBalanceEq { get; set; }
    public decimal DbAmount { get; set; }
    public decimal DbAmountEq { get; set; }
    public decimal CrAmount { get; set; }
    public decimal CrAmountEq { get; set; }
}