namespace AracTakip.Models;

public class Arac : BaseModel
{
    public string Plaka { get; set; }
    public Model Model { get; set; }
    public int Yil { get; set; }
    public byte[] Fotograf { get; set; }
    public VitesTipleri VitesTipi { get; set; }
    public YakitTipleri YakitTipi { get; set; }
}