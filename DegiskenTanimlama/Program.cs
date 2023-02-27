namespace DegiskenTanimlama;
internal class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
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

        //Karakter tipleri

        char karakter = 'a';
        karakter = '\u006A';

        Console.WriteLine(karakter);

        string kelime = "Merhaba Dünya";

        char[] kelimeDizi = new[] { 'M', 'e', 'r' };

        char harf = kelime[1];

        Console.WriteLine(kelimeDizi[2]);
        Console.WriteLine(kelime[2]);

        //Mantıksal tip

        bool dogruMu = true;

        //Mantıksal operatörler

        // > < >= <= == != ! işlem  && ||
        // 
        dogruMu = degiskenInt > degiskenDouble;
        Console.WriteLine(dogruMu);
        dogruMu = degiskenUShort < degiskenInt && kelime.Length > 10;

        bool tekMi = a % 2 == 1;

        Console.WriteLine("İşlemin sonucu: " + (5 + 6 + 9));
        Console.WriteLine(tekMi.ToString());
        Console.WriteLine(tekMi + "");
        Console.WriteLine(tekMi);
        Console.Clear();
        Console.CursorSize = 14;
        Console.WriteLine();

        for (int i = 0; i < 30; i++)
        {
            DateTime simdi = DateTime.Now;

            Console.WriteLine(simdi.Hour.ToString("00") + ":" + simdi.Minute.ToString("00") + ":" + simdi.Second.ToString("00"));
            Console.WriteLine($"{simdi.Hour:00}:{simdi.Minute:00}:{simdi.Second:00}");
            Console.WriteLine($"{simdi:dd:MM:yyyy - HH:mm:ss}");
            Thread.Sleep(1000);
            Console.Clear();
        }

        //escape sequances 

        /*
         * \n newLine
         * \t tab
         * \b backSpace
         * \\
         * \"
         * @
         */

        kelime = "Bu hikayenin çok uzun bir kısmını \n\"Bu metin\" karşılamaktadır.";
        string path = @"c:\new\falan.txt";
        Console.WriteLine(kelime);
    }
}



