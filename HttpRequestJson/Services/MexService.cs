using System.Net;
using HttpRequestJson.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HttpRequestJson.Services;

public class MexService
{
    private readonly string ApiEndPoint = "https://api.mexc.com";

    public bool CheckApiStatus()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(ApiEndPoint);
        HttpResponseMessage response = client.GetAsync("/api/v3/time").Result;
        if (response.StatusCode == HttpStatusCode.OK)
        {
            string result = response.Content.ReadAsStringAsync().Result;
            return true;
        }
        else if (response.StatusCode == HttpStatusCode.NotFound)
        {
            throw new Exception("API adresi bulunamadı");
        }

        return false;
    }

    public List<SymbolInfo>? GetSymbols()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(ApiEndPoint);
        HttpResponseMessage response = client.GetAsync("/api/v3/exchangeInfo").Result;
        if (response.StatusCode == HttpStatusCode.OK)
        {
            string result = response.Content.ReadAsStringAsync().Result;
            ExchangeInfo exchangeInfo = JsonConvert.DeserializeObject<ExchangeInfo>(result);
            return exchangeInfo.Symbols;
        }

        return null;
    }

    public decimal GetSymbolData(string symbol)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(ApiEndPoint);
        HttpResponseMessage response = client.GetAsync($"/api/v3/ticker/price?symbol={symbol}").Result;
        if (response.StatusCode == HttpStatusCode.OK)
        {
            string result = response.Content.ReadAsStringAsync().Result;
            var data = (JObject)JsonConvert.DeserializeObject(result);
            return decimal.Parse(data["price"].ToString().Replace(".",","));
        }

        return -1;
    }
}