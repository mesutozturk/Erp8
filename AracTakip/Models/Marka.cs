namespace AracTakip.Models;

public class Marka : BaseModel
{
    public string Ad { get; set; }
    public byte[] Logo { get; set; }
    public List<Model> Modeller { get; set; } = new List<Model>();
}