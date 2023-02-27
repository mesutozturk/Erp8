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

                lstKisiler.DisplayMember = "Ad";
                lstKisiler.Items.Add(yeniKisi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu! {ex.Message}");
            }
        }
    }
}
