/* Hata Yönetimi
 * 1) Kullanıcı giriş işlemlerinde
 * 2) Dosya işlemlerinde
 * 3) Ağ işlemlerinde
 * 4) Veritabanı işlemlerinde
 * 5) Matematiksel işlemlerde
 * 6) Programın çalışma zamanında oluşabilecek hatalarda
 * Kullanılmalıdır
 */

using System.Xml;

Console.WriteLine("0 ile 10 arasında bir sayı giriniz");
int hak = 3;
do
{
    try
    {
        int girilenSayi = Convert.ToInt32(Console.ReadLine());
        if (girilenSayi < 0 || girilenSayi > 10)
        {
            throw new Exception("Girilen sayı 0 ile 10 arasında olmalıdır");
        }

        Console.WriteLine($"Girdiğiniz sayı: {girilenSayi}");
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        hak--;
    }
    finally // bu blok her durumda çalışır. Hata olsa da olmasa da
    {
        Console.WriteLine("İşlem tamamlandı");
    }
} while (hak > 0);
if(hak>0)
    Console.WriteLine("Aferin başarabildin");
else
    Console.WriteLine("Başaramadın :(");

Console.WriteLine("Bir sayı daha girin");
string giris = Console.ReadLine();
if (int.TryParse(giris, out int sayi))
{
    Console.WriteLine("Girdiğiniz sayı: " + sayi);
}
else
{
    Console.WriteLine("Sayı girmeyi beceremedin");
}
