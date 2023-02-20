namespace DegiskenTanimlama;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Değişken tanımlama");

        //Tamsayı değişken tipleri

        byte degiskenByte = 2;
        short degiskenShort = 5;
        ushort degiskenUShort = 4;
        int degiskenInt = 0;
        uint degiskenUInt = 0;
        long degiskenLong = 0;
        ulong degiskenULong = 0L;

        //ondalık değişken tipleri

        double degiskenDouble = 0.5D;
        float degiskenFloat = 0.5F;
        decimal degiskenDecimal = 0.5M;

        degiskenInt = 1_999_999;
        degiskenInt = 0b101010110;
        degiskenInt = 0x123af21c;
        Console.WriteLine(degiskenInt);

        int sonuc1 = 9 / 3;
        sonuc1 = Convert.ToInt32(5 / 2d);
        sonuc1 = (int)(5 / 2d);
        Console.WriteLine(sonuc1);
        //Console.Write("asd");

        //Aritmetik operatörler
        // + - * / %

        int a = 5;

        int b = 10;
        //b++;
        a = ++b;
        Console.WriteLine(a);
        Console.WriteLine(b);

        a = a + 10;
        a += 10;

        a = a % 2;
        a %= 2;
    }
}