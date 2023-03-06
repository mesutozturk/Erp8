namespace StatikNesneler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 5;
            double kareAlan = kare.AlanHesapla();

            kareAlan = Kare.AlanHesapla(5);

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.X = 5;
            dikdortgen.Y = 10;
            double dikdortgenAlan = dikdortgen.AlanHesapla();

            dikdortgenAlan = Dikdortgen.AlanHesapla(5, 10);

            //Geometri geometri = new Geometri();

            double cemberinAlani = Geometri.AlanHesapla(5);
            cemberinAlani = Geometri.AlanHesapla(5, 3.14);

        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                SingletonDeneme singletonDeneme = SingletonDeneme.GetInstance();
                Console.WriteLine(singletonDeneme.Id);
            }

            MessageBox.Show("Tüm Sýnýflar Üretildi");
        }
    }
}