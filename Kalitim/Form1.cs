using Kalitim.Lib;

namespace Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sekil yeniSekil = new Sekil();
            //yeniSekil.X = 4;

            Sekil yeniKare = new Kare
            {
                X = 5
            };
            this.Text = $"Karenin alaný: {yeniKare.AlanHesapla()}";

            Sekil yeniDikdortgen = new Dikdortgen()
            {
                X = 5,
                Y = 12
            };
            this.Text = $"Dikdörtgenin alaný: {yeniDikdortgen.AlanHesapla()}";

            sekiller.Add(yeniKare);
            sekiller.Add(yeniDikdortgen);
            //sekiller.Add(yeniSekil);
            foreach (var item in sekiller)
            {
                double cevre = item.CevreHesapla();
            }
        }
    }
}