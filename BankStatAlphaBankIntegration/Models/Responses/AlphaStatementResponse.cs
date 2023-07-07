namespace BankStatAlphaBankIntegration.Models.Responses;

public class AlphaStatementResponse
{
    public List<AlphaStatementError> Errors { get; set; }
    public List<AlphaStatementStatistics> Statistics { get; set; }
    public int TotalRowCount { get; set; }
    public string CacheKey { get; set; }
    public List<AlphaStatement> Pages { get; set; }
}