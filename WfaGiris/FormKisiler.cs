using System.Security.Cryptography;

namespace WfaGiris
{
    public partial class FormKisiler : Form
    {
        public FormKisiler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Kisi kisi = new Kisi();
                //kisi.Ad = txtAd.Text;
                //kisi.Soyad = txtSoyad.Text;
                //kisi.Tckn = txtTckn.Text;
                //kisi.DogumTarihi = dtpDogumTarihi.Value;
                //kisi.Telefon = txtTelefon.Text;
                //kisi.Email = txtEmail.Text;
                Kisi yeniKisi = new Kisi() //Object Initializer
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Tckn = txtTckn.Text,
                    DogumTarihi = dtpDogumTarihi.Value,
                    Email = txtEmail.Text,
                    Telefon = txtTelefon.Text
                };

                //lstKisiler.DisplayMember = "Ad";
                lstKisiler.Items.Add(yeniKisi);
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu! {ex.Message}");
            }
        }

        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    //(item as DateTimePicker).Value = DateTime.Now;
                    //((DateTimePicker)item).Value = DateTime.Now;
                    dPicker.Value = DateTime.Now;
                }
                else if (item is CheckBox cBox)
                    cBox.Checked = false;
                else if (item is ComboBox combo)
                    combo.SelectedIndex = -1;
                else if (item is ListBox listBox)
                    listBox.SelectedIndex = -1;
            }
            //txtAd.Text = string.Empty;
            //txtSoyad.Text = string.Empty;
            //txtTckn.Text = string.Empty;
            //txtTelefon.Text = string.Empty;
            //txtEmail.Text = string.Empty;
            //dtpDogumTarihi.Value = DateTime.Now;

        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            var seciliKisi = lstKisiler.SelectedItem as Kisi;

        }
    }
}
