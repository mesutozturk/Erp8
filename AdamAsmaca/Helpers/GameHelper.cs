using Random = System.Random;

namespace AdamAsmaca.Helpers;
public class GameHelper
{
    public GameHelper()
    {
        SeciliSoru = RastgeleSoruSec();
        _ekran = new char[SeciliSoru.Length];
        for (int i = 0; i < SeciliSoru.Length; i++)
        {
            _ekran[i] = '_';
        }
        _puan = SeciliSoru.Length * 100;
    }

    public readonly string SeciliSoru;
    public string[] Sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
    private int _hak = 6;
    private int _puan = 0;
    private char[] _ekran;

    private string RastgeleSoruSec() => Sorular[new Random().Next(Sorular.Length)];
    public int HakKontrol() => _hak;
    public int PuanKontrol() => _puan;
    public string EkraniYaz() => string.Join(' ', _ekran);

}