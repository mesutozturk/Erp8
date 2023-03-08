namespace AracTakip.Models;

public class Model : BaseModel
{
    public string Ad { get; set; }
    public KasaTipleri KasaTipi { get; set; }
    public Marka Marka { get; set; }
    public List<Arac> Araclar { get; set; } = new List<Arac>();
}