namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool _calisiyorMu = false, _duraklatildiMi = false;
        DateTime _oncekiZaman, _sonrakiZaman, _kronometre = new DateTime();

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
            _calisiyorMu = !_calisiyorMu;
            if (_calisiyorMu)
            {
                _oncekiZaman = DateTime.Now;
                tmr1.Start();
                btnBaslatDurdur.Text = "Duraklat";
            }
            else
            {
                _duraklatildiMi = true;
                tmr1.Stop();
                btnBaslatDurdur.Text = "Baþlat";
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            _sonrakiZaman = _oncekiZaman;
            _oncekiZaman = DateTime.Now;

            TimeSpan fark = _oncekiZaman - _sonrakiZaman;
            _kronometre = _kronometre.AddMilliseconds(fark.TotalMilliseconds);
            lblEkran.Text = _kronometre.ToString("mm:ss:fff");
        }
    }
}