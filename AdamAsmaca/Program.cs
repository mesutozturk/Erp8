using AdamAsmaca.Helpers;

GameHelper game = new GameHelper();
Random rnd = new Random();
do
{
    Console.WriteLine(game.EkraniYaz());
    game.TahminYap(Console.ReadLine());
} while (game.OyunAktifMi());

