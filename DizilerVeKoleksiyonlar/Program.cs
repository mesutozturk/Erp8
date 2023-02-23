// dizi aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.


using System.Collections;

int[] sayilar = new int[5];

int[] sayilar2 = new[] { 1, 5, 6, 3, 2 };

unsafe
{
    int number = 43;
    int* pNumber = &number;
    Console.WriteLine(number);
}

for (int i = 0; i < sayilar2.Length; i++)
{
    Console.WriteLine(sayilar2[i]);
}

foreach (var sayi in sayilar2)
{
    Console.WriteLine(sayi);
}

string cumle = "dizi aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.";
string[] kelimeler = cumle.Split(' ');
foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

sayilar[0] = 5;
sayilar[1] = 4;
sayilar[2] = 3;
sayilar[3] = 2;
sayilar[4] = 1;

Random rnd = new Random();

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 100);
}

Console.WriteLine(sayilar[rnd.Next(sayilar.Length)]);

Console.Clear();


//1-49 arasında 6 tane benzersiz sayı seçip diziye dolduran kod parçası
int[] secimler = new int[6];

for (int i = 0; i < secimler.Length; i++)
{
    int sayi = rnd.Next(1, 50);
    //int index = Array.IndexOf(secimler, sayi);
    //if (index == -1)
    //    secimler[i] = sayi;
    //else
    //    i--;
    if (secimler.Contains(sayi))
        i--;
    else
        secimler[i] = sayi;
}

Array.Resize(ref secimler, 10);


object a = 1;
object b = "Kamil";
object c = DateTime.Now;


object[] objeler = new object[3];
objeler[0] = a;
objeler[1] = b;
objeler[2] = c;

ArrayList liste = new ArrayList();
liste.Add(a);
liste.Add(b);
liste.Add(c);

List<double> sayilar3 = new List<double>();
sayilar3.Add(1);
sayilar3.Add(2);
sayilar3.Add(3);
sayilar3.Add(4);

var sonuc = sayilar3.Where(x => x > 18 && x < 25).ToList();

//ödev1
//Program her çalıştığında 0-100 arasında rastgele bir sayı bulacak ve bizden o sayıyı tahmin etmemizi isteyecek. Her tahminden sonra yukarı/aşağı diye bizi yönlendirecek. Tahminimiz doğru olduğunda kaç tahminde bulduğumuzu ekrana yazdıracak. Tüm girişler yanlış olsa dahi tahmin olarak değerlendirilecek.

//ödev2
//programa dışarıdan 1-6 arası bir sayı girilecek ve program her seferinde 2 zar atacak. Atılan zar çiftleri eğer girdiğimiz sayıya eşit olursa program bitecek ve kaç denemede bulduğunu ekrana yazacak.(önceki denemeleri de ekrana yazdırabilirsiniz)

//ödev3 dışarıdan girilen 0-9999 arasındaki tüm sayıların okunuşunu ekrana yazan programı yazınız.

var rastgeleSayilar = Enumerable.Range(1, 49).OrderBy(x => rnd.Next()).Take(6).ToList();
Console.WriteLine();


int sayi1 = 5;
int sayi2 = 10;
sayi1 = sayi2;
sayi2 = 15;
Console.WriteLine(sayi1); //10

int[] sayilar11 = new[] { 1, 2, 3 };
int[] sayilar22 = new[] { 4, 5, 6 };
sayilar11 = sayilar22;
sayilar22[0] = 10;
Console.WriteLine(sayilar11[0]);//10


int[] yeniSayilar = sayilar[0..^3]; //0dan 3. indexe kadar 3(dahil değil) elemanları yeni diziye aktarır

//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-

bool xorDeneme = true ^ false; //true

bool isActive = true;

isActive = isActive && xorDeneme;
isActive &= xorDeneme;
isActive |= xorDeneme;
isActive ^= xorDeneme;

//Random rnd23 = new();
//rnd23 = null;

//if (rnd23 != null && rnd23.Next() == 10)
//{

//}

