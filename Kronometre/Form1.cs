namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _calisiyorMu = false;
        private DateTime _oncekiZaman, _sonrakiZaman, _kronometre = new DateTime(), _hedefZaman;

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
            _calisiyorMu = !_calisiyorMu;
            if (_calisiyorMu)
            {
                if (cbGeriSayim.Checked)
                {
                    _kronometre = new DateTime(1, 1, 1, cmbSaat.SelectedIndex, cmbDakika.SelectedIndex,
                        cmbSaniye.SelectedIndex);
                    _hedefZaman = _kronometre;
                }
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
                try
                {
                    _kronometre = _kronometre.AddMilliseconds(fark.TotalMilliseconds * -1);
                    var hedef = _hedefZaman - new DateTime();
                    var fark2 = _hedefZaman - _kronometre;
                    var sonuc = (int)(fark2.TotalMilliseconds / hedef.TotalMilliseconds * 100);
                    pbKalanSure.Value = sonuc;
                }
                catch
                {
                    _kronometre = new DateTime();
                    tmr1.Stop();
                    btnBaslatDurdur.PerformClick();
                    pbKalanSure.Value = 100;
                }
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
            FormuTemizle(this.Controls);
        }

        private void FormuTemizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is CheckBox cBox)
                    cBox.Checked = false;
                else if (item is ComboBox combo)
                    combo.SelectedIndex = 0;
                else if (item is GroupBox gBox)
                    FormuTemizle(gBox.Controls);
            }

            Console.WriteLine();
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