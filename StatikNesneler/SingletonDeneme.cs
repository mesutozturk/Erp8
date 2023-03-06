namespace StatikNesneler;
public class SingletonDeneme
{
    public Guid Id { get; set; }

    private SingletonDeneme()
    {
        Thread.Sleep(10 * 1000);
        this.Id = Guid.NewGuid();
    }
    private static SingletonDeneme _singletonDeneme;
    public static SingletonDeneme GetInstance()
    {
        return _singletonDeneme ??= new SingletonDeneme(); // ?? operatörü null kontrolünü if komutu yazmadan yapar. Aşağıdaki örnekle aynı mantıkta çalışır.
    }

    public static SingletonDeneme Instance
    {
        get
        {
            if (_singletonDeneme == null)
                _singletonDeneme = new SingletonDeneme();
            return _singletonDeneme;
        }
    }
}