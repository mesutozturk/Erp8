namespace SayiOkuyucuFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (txtSayi.Text.Length >= 4)
                e.Handled = true;
        }

        private void txtSayi_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSayi.Text.Length != 0)
                SayiyiMetneCevir();
            else if (txtSayi.Text.Length == 0)
            {
                txtSayi.Text = "0";
                SayiyiMetneCevir();
            }
        }
        private void SayiyiMetneCevir()
        {
            string[] birler = { "", "Bir", "Ýki", "Üç", "Dört", "Beþ", "Altý", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kýrk", "Elli", "Altmýþ", "Yetmiþ", "Seksen", "Doksan" };
            string[] yuzler = { "", "Yüz", "ÝkiYüz", "ÜçYüz", "DörtYüz", "BeþYüz", "AltýYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
            string[] binler = { "", "Bin", "ÝkiBin", "ÜçBin", "DörtBin", "BeþBin", "AltýBin", "YediBin", "SekizBin", "DokuzBin" };
            string[] milyonlar = { "", "BirMilyon", "ÝkiMilyon", "ÜçMilyon", "DörtMilyon", "BeþMilyon", "AltýMilyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
            int girilenSayi = int.Parse(txtSayi.Text);

            if (girilenSayi == 0)
            {
                lblEkran.Text = "Sýfýr";
                return;
            }

            int basamak1 = girilenSayi % 10;
            int basamak10 = girilenSayi / 10 % 10;
            int basamak100 = girilenSayi / 100 % 10;
            int basamak1000 = girilenSayi / 1000 % 10;
            int basamak10000 = girilenSayi / 10000 % 10;
            int basamak100000 = girilenSayi / 100000 % 10;
            int basamak1000000 = girilenSayi / 1000000 % 10;
            string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";
            lblEkran.Text = okunus;
        }
    }
}