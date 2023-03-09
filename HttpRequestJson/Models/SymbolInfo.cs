namespace HttpRequestJson.Models;

public class SymbolInfo
{
    public string Symbol { get; set; }
    public string Status { get; set; }
    public string BaseAsset { get; set; }
    public int BaseAssetPrecision { get; set; }
    public string QuoteAsset { get; set; }
    public int QuotePrecision { get; set; }
    public int QuoteAssetPrecision { get; set; }
    public int BaseCommissionPrecision { get; set; }
    public int QuoteCommissionPrecision { get; set; }
    public string[] OrderTypes { get; set; }
    public bool QuoteOrderQtyMarketAllowed { get; set; }
    public bool IsSpotTradingAllowed { get; set; }
    public bool IsMarginTradingAllowed { get; set; }
    public string QuoteAmountPrecision { get; set; }
    public string BaseSizePrecision { get; set; }
    public string[] Permissions { get; set; }
    public object[] Filters { get; set; }
    public string MaxQuoteAmount { get; set; }
    public string MakerCommission { get; set; }
    public string TakerCommission { get; set; }
    public string QuoteAmountPrecisionMarket { get; set; }
    public string MaxQuoteAmountMarket { get; set; }

    public override string ToString()
    {
        return Symbol;
    }
}