using AracTakip.Data;
using Newtonsoft.Json;

namespace AracTakip.Helpers;

public class DataHelper
{
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AracData.json";
    public static void Save(EnvanterContext context)
    {
        if (File.Exists(Path))
            File.Delete(Path);
        FileStream fs = new(Path, FileMode.OpenOrCreate);
        StreamWriter sw = new(fs);
        //JSON serialize referance loop ignore
        var seri = JsonConvert.SerializeObject(context, new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            MaxDepth = 1
        });
        sw.Write(seri);
        fs.Close();
        fs.Dispose();
    }

    public static EnvanterContext Load()
    {
        FileStream fs = new(Path, FileMode.OpenOrCreate);
        StreamReader sr = new(fs);
        string data = sr.ReadToEnd();
        if (!string.IsNullOrEmpty(data))
        {
            return JsonConvert.DeserializeObject<EnvanterContext>(data);
        }
        fs.Close();
        fs.Dispose();
        return null;
    }
}