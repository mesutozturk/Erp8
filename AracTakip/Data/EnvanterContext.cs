using System.Runtime.CompilerServices;
using AracTakip.Models;

namespace AracTakip.Data;

public class EnvanterContext
{
    public List<Marka> Markalar { get; set; } = new();
    public List<Model> Modeller { get; set; } = new();
    public List<Arac> Araclar { get; set; } = new();

    public Model? SearchModel(Func<Model, bool> predicate)
    {
        return this.Modeller.FirstOrDefault(predicate);
    }

   
}