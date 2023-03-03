namespace Kitpaci;

public class Kitap : Urun
{
    public Artist Yazar { get; set; }
    public int BasimYili { get; set; }
    public string YayinEvi { get; set; }
    public string ISBN { get; set; }
    public string Dil { get; set; }
}