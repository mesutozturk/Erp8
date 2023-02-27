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
                //TODO: Formdaki textbox ve datetimepicklar'ı ilk açıldığı hale getirin
                item.Text = string.Empty;
            }
            //txtAd.Text = string.Empty;
            //txtSoyad.Text = string.Empty;
            //txtTckn.Text = string.Empty;
            //txtTelefon.Text = string.Empty;
            //txtEmail.Text = string.Empty;
            //dtpDogumTarihi.Value = DateTime.Now;

        }
    }
}
