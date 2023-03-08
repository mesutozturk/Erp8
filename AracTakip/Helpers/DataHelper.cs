using AracTakip.Data;
using Newtonsoft.Json;

namespace AracTakip.Helpers;

public class DataHelper
{
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AracData.json";
    public static void Save(EnvanterContext context)
    {
        FileStream fs = new(Path, FileMode.OpenOrCreate);
        StreamWriter sw = new(fs);
        sw.Write(JsonConvert.SerializeObject(context));
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