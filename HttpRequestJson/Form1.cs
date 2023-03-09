using HttpRequestJson.Models;
using HttpRequestJson.Services;

namespace HttpRequestJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MexService _mexService;
        private List<SymbolInfo> _symbols = new List<SymbolInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            _mexService = new MexService();
            bool status = _mexService.CheckApiStatus();
            this.Text = status ? "API OK" : "API Error";
            //https://api.mexc.com/api/v3/exchangeInfo
            _symbols = _mexService.GetSymbols()
                .Where(x => x.IsSpotTradingAllowed)
                .OrderBy(x => x.Symbol)
                .ToList();

            lstSymbol.DataSource = _symbols;
        }

        private void lstSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSymbol.SelectedItem == null)
            {
                tmrVeri.Stop();
                return;
            }
            tmrVeri.Start();
            tmrVeri.Interval = 2000;
        }

        private void tmrVeri_Tick(object sender, EventArgs e)
        {
            if (lstSymbol.SelectedItem == null)
            {
                tmrVeri.Stop();
                return;
            }
            SymbolInfo symbol = (SymbolInfo)lstSymbol.SelectedItem;
            decimal price = _mexService.GetSymbolData(symbol.Symbol);
            if (price > 0)
            {
                //lblInfo.Text = price.ToString("###.###.###,000");
                lblInfo.Text = price.ToString("N");
                //lblInfo.Text = price.ToString("C");
            }
        }
    }
}