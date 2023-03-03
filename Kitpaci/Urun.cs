namespace Kitpaci;
public abstract class Urun
{
    private decimal _fiyat;
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat
    {
        get => _fiyat;
        set
        {
            if (value <= 0)
                throw new Exception("Fiyat 0'dan büyük olmalıdır");
            _fiyat = value;
        }
    }
    //protected sadece kalıtım verildiği sınıflar tarafından erişilebilir.
    public int Stok { get; protected set; } = 0;
    public byte[] Fotograf { get; set; }
    public double IndirimOrani { get; set; } = 0;
    public int SatisYap(int adet)
    {
        if (this.Stok >= adet)
            this.Stok -= adet;
        else
            throw new Exception("Stokta yeterli ürün yok");
        return this.Stok;
    }
    public int StokEkle(int adet)
    {
        this.Stok += adet;
        return this.Stok;
    }
}