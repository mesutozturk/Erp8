using AracTakip.Models;

namespace AracTakip.Data;

public class EnvanterContext
{
    public List<Marka> Markalar { get; set; } = new();
    public List<Model> Modeller { get; set; } = new();
    public List<Arac> Araclar { get; set; } = new();
}