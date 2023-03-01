namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _calisiyorMu = false;
        private DateTime _oncekiZaman, _sonrakiZaman, _kronometre = new DateTime();

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
            _calisiyorMu = !_calisiyorMu;
            if (_calisiyorMu)
            {
                if (cbGeriSayim.Checked)
                    _kronometre = new DateTime(1, 1, 1, cmbSaat.SelectedIndex, cmbDakika.SelectedIndex,
                        cmbSaniye.SelectedIndex);
                else
                {
                    _kronometre = new DateTime();
                }
                _oncekiZaman = DateTime.Now;
                tmr1.Start();
                btnBaslatDurdur.Text = "Duraklat";
                btnBaslatDurdur.FlatStyle = FlatStyle.Flat;
                btnBaslatDurdur.BackColor = Color.Chartreuse;
                btnSifirla.Enabled = false;
            }
            else
            {
                tmr1.Stop();
                btnBaslatDurdur.Text = "Baþlat";
                btnBaslatDurdur.FlatStyle = FlatStyle.Standard;
                btnBaslatDurdur.BackColor = Color.IndianRed;
                btnSifirla.Enabled = true;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            _sonrakiZaman = _oncekiZaman;
            _oncekiZaman = DateTime.Now;
            TimeSpan fark = _oncekiZaman - _sonrakiZaman;

            if (cbGeriSayim.Checked)
            {
                _kronometre = _kronometre.AddMilliseconds(fark.TotalMilliseconds * -1);
            }
            else
            {
                _kronometre = _kronometre.AddMilliseconds(fark.TotalMilliseconds);
            }
            lblEkran.Text = _kronometre.ToString("mm:ss:fff");
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            _kronometre = new DateTime();
            lblEkran.Text = _kronometre.ToString("mm:ss:fff");
        }

        private void cbGeriSayim_CheckedChanged(object sender, EventArgs e)
        {
            gbKontrol.Visible = cbGeriSayim.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 60; i++)
            {
                cmbSaniye.Items.Add(i);
                cmbDakika.Items.Add(i);
                cmbSaat.Items.Add(i);
            }
            cmbSaniye.SelectedIndex = 0;
            cmbDakika.SelectedIndex = 0;
            cmbSaat.SelectedIndex = 0;
        }
    }
}