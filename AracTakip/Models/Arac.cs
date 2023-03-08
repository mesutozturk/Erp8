namespace AracTakip.Models;

public abstract class BaseModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
public class Arac : BaseModel
{
    public string Plaka { get; set; }
    public Model Model { get; set; }
}

public class Marka : BaseModel
{
    public string Ad { get; set; }
    public byte[] Logo { get; set; }
    public List<Model> Modeller { get; set; } = new List<Model>();
}

public class Model : BaseModel
{
    public string Ad { get; set; }
    public KasaTipi KasaTipi { get; set; }
    public Marka Marka { get; set; }
    public List<Arac> Araclar { get; set; } = new List<Arac>();
}

public enum KasaTipi
{
    HatchBack,
    Sedan,
    StationWagon,
    Coupe,
    Convertible,
    Suv,
    Crossover,
    Van,
    Pickup,
    Minivan,
    Minibus,
    Limousine,
    Roadster,
    Targa
}