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
        _oyunDevamEdiyorMu = true;
    }

    public readonly string SeciliSoru;
    private string[] _sorular = { "zeytinburnu", "kahramanmaraş", "çanakkale", "hayrabolu" };
    private int _hak = 6;
    private int _puan = 0;
    private char[] _ekran;
    private bool _oyunDevamEdiyorMu;
    private readonly List<char> _oncekiTahminler = new();
    private readonly Grafik _grafik = new();

    private string RastgeleSoruSec() => _sorular[new Random().Next(_sorular.Length)];
    public int HakKontrol() => _hak;
    public int PuanKontrol() => _puan;
    public string EkraniYaz()
    {
        string skorBoard = $"Puan: {_puan}\tKalan Hak: {_hak}";
        string ekran = string.Join(' ', _ekran);
        if (_hak == 5)
            _grafik.KafaCiz();
        else if (_hak == 4)
            _grafik.GovdeCizimi();
        else if (_hak == 3)
            _grafik.Uzuvlar(Uzuvlar.SagKol);
        else if (_hak == 2)
            _grafik.Uzuvlar(Uzuvlar.SolKol);
        else if (_hak == 1)
            _grafik.Uzuvlar(Uzuvlar.SagBacak);
        else if(_hak == 0)
            _grafik.Uzuvlar(Uzuvlar.SolBacak);

        _grafik.EkranaYaz();
        return $"{skorBoard}\n{ekran}";
    }
    public bool TahminYap(string tahmin)
    {
        bool dogruMu = false;
        if (!string.IsNullOrEmpty(tahmin) && tahmin.Length == 1)
        {
            //harf tahmini
            char harf = tahmin.ToLower()[0];
            bool oncekiTahminMi = _oncekiTahminler.Contains(harf);
            if (!oncekiTahminMi)
                for (int i = 0; i < SeciliSoru.Length; i++)
                    if (SeciliSoru[i] == harf)
                    {
                        dogruMu = true;
                        _ekran[i] = harf;
                        _oncekiTahminler.Add(harf);
                    }

        }
        else if (!string.IsNullOrEmpty(tahmin))
        {
            //kelime tahmini
            if (SeciliSoru == tahmin.ToLower())
            {
                dogruMu = true;
                _oyunDevamEdiyorMu = false;
            }
        }

        if (!dogruMu)
        {
            _hak--;
            if (_hak == 0)
            {
                _oyunDevamEdiyorMu = false;
                _puan = 0;
            }
            else
                _puan = (int)(_puan * 0.9);
        }

        if (!_ekran.Contains('_'))
            _oyunDevamEdiyorMu = false;

        return dogruMu;
    }
    public bool OyunAktifMi() => _oyunDevamEdiyorMu;
}