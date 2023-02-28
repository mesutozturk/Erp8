namespace ZarTahminWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random _rnd = new Random();
        private int _zar1 = 0, _zar2 = 0, _sayi = 0, _sayac = 0;
        private void btnDondur_Click(object sender, EventArgs e)
        {
            if (cmbSayilar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir sayý seçiniz.");
                return;
            }
            _sayi = cmbSayilar.SelectedIndex + 1;
            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            _sayac++;
            _zar1 = _rnd.Next(1, 7);
            _zar2 = _rnd.Next(1, 7);
            lstSonuc.Items.Add($"{_sayac:00}) {_zar1}-{_zar2}");
            btn1.Text = _zar1.ToString();
            btn2.Text = _zar2.ToString();
            if (_zar1 == _zar2 && _zar1 == _sayi)
            {
                this.Text = $"{_sayac} denemede {_sayi}-{_sayi} tahmini bulundu";
                tmr1.Stop();
            }
        }
    }
}