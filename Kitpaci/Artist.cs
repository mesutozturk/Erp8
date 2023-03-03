namespace Kitpaci;

public class Artist
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Ulke { get; set; }
    public string Cinsiyet { get; set; }
    public DateTime DogumTarihi { get; set; }
    public string DogumYeri { get; set; }
    public string Ozgecmis { get; set; }

    public List<Urun> Urunler { get; set; } = new List<Urun>();
}