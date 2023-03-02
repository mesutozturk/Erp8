namespace Kalitim.Lib;
public abstract class Sekil
{
    public Sekil()
    {
        
    }
    public Sekil(int x)
    {
        this.X = x;
    }
    public double X { get; set; }

    public virtual double AlanHesapla() => X * X; //virtual tanımlı class öğeleri kalıtım alınan yerlerde tanımlandığı gibi çalışır. Eğer çalışma şeklini değiştirmek istiyorsak override ile değiştirebiliriz.
    //public double CevreHesapla() => 4 * X;
    public abstract double CevreHesapla();
}