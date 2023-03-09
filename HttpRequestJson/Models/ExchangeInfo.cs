namespace HttpRequestJson.Models;

public class ExchangeInfo
{
    public string timezone { get; set; }
    public long serverTime { get; set; }
    public object[] rateLimits { get; set; }
    public object[] exchangeFilters { get; set; }
    public List<SymbolInfo> Symbols { get; set; }=new List<SymbolInfo>();
}