namespace Kalitim.Lib;

public sealed class DikUcgen : Dikdortgen //DikUcgen sınıfından kalıtım vermek istemediğimiz için sealde keywordu ekledik
{
    public DikUcgen()
    {

    }
    public DikUcgen(int x, int y) : base(x, y)
    {

    }
    public override double AlanHesapla()
    {
        return base.AlanHesapla() / 2;
    }

    public override double CevreHesapla()
    {
        return (X + Y) + Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
    }
}

//public class SuperUcgen : DikUcgen //DikUcgen sınıfı sealed olduğu için kalıtım alınamaz.
//{

//}