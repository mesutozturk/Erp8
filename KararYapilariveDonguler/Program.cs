//Karar yapıları ve Döngüler

//if (kosul)
//{
//    işlemler
//}
//else if (kosul)
//{
//    işlemler
//}
//else
//{
//    işlemler
//}

//switch (degisken)
//{
//    case deger1:
//        işlemler
//        break;
//    case deger2:
//        islemler
//        break;
//    default:
//        işlemler
//        break;
//}

//while (kosul)
//{
//    islemler
//}

//do
//{
//    islemler
//}while(kosul);

//for (int i = 0; i < 10; i++)
//{
//    islemler
//}

//foreach (var item in collection)
//{
//    islemler
//}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    i--;
}

while (true)
{
    Console.WriteLine(DateTime.Now);
    if (DateTime.Now.Minute == 15)
        break;
}

do
{
    Console.WriteLine(DateTime.Now);
} while (true);

for (; ; )
{

}

//09:00 - 09:15
//09:15 - 09:30

//11:45 - 12:00
//13:00 - 13:15
//13.15 - 13.30

//16:45 - 17:00

int sayi2 = 324;
if (sayi2 % 2 == 0)
    Console.WriteLine("Çift");
else
    Console.WriteLine("Tek");

string sonuc = sayi2 % 2 == 0 ? "Çift" : "Tek"; //Ternary-if

Console.WriteLine(sayi2 % 2 == 0 ? "Çift" : "Tek");

Random rnd;
//rnd.Next(100);

if (rnd == null)
    rnd = new Random();

sayi2 = sayi2 + 1;
sayi2 += 1;

rnd = rnd ?? new Random();

rnd ??=new Random();

// String methotlar 
// Math Methodlar
// DateTime Methodlar

