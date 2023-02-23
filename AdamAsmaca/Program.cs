using AdamAsmaca.Helpers;

ConsoleKey key;
do
{
    GameHelper game = new GameHelper();
    Random rnd = new Random();
    do
    {
        Console.WriteLine(game.EkraniYaz());
        game.TahminYap(Console.ReadLine());
    } while (game.OyunAktifMi());

    if (game.HakKontrol() > 0)
    {
        Console.WriteLine(game.SeciliSoru);
        Console.WriteLine("Tebrikler Bildiniz");
        Console.WriteLine($"Puanınız: {game.PuanKontrol()}");
    }

    Console.WriteLine("Tekrar oynamak için E tuşuna basınız");

    key = Console.ReadKey().Key;
} while (key == ConsoleKey.E);