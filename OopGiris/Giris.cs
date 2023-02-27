namespace OopGiris
{
    internal class Giris
    {
        //Access Modifiers - Erişim Belirleyiciler
        //public - her yerden erişilebilir
        //private - sadece tanımlandığı sınıf içinden erişilebilir
        //protected - 
        //internal - sadece tanımlandığı proje içinden erişilebilir
        //protected internal -
        //
        //Default Access Modifiers - Varsayılan Erişim Belirleyiciler
        //class, struct, interface, enum - internal
        //field, property, method, event - private

        //Sınıf Öğeleri
        //Constructor - Yapıcı Metot
        //Her statik olmayan sınıf içerisinde yazmasakta bir adet yapıcı metot vardır.
        //Yapıcı metotlar sınıfın örneği (instance) alındığında ilk çalışan metottur.
        //Yapıcı metotlarda methot overloading yapılabilir.

        //Fields - Alanlar
        //Sınıf içerisinde tanımlanan değişkenlere field/alan denir.
        //Field'lar sınıfın örneği alındığında bellekte yer kaplarlar.

        //Properties - Özellikler
        //Field'ları encapsulation yapmak için kullanılır.

        //Methods - Metotlar
        //Sınıf içerisinde tanımlanan fonksiyonlara metot denir.

        //Events - Olaylar

        //Operator Overloading - Operatör tanımlama
        //Sınıf içerisinde tanımlanan operatörlerin davranışlarını değiştirmek için kullanılır.


        //Static - Statik
        //Static field'lar bellekte sadece bir kere yer kaplarlar.

        public Giris()
        {
            //this.IslemTarihi = DateTime.Now;
        }

        private decimal _fiyat;
        private DateTime _dogumTarihi;

        // falan.Fiyat = 10;

        public decimal Fiyat
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Fiyat sıfırdan küçük olamaz");
                }
                _fiyat = value;
            }
            get
            {
                return Math.Round(_fiyat, 2);
            }
        }

        //Full Property 1adet field'ın encapsule edilmesi ile oluşur.

        //Auto Property 
        public DateTime IslemTarihi { get; private set; } = DateTime.Now;
        public int Yas //readonly property
        {
            get => DateTime.Now.Year - this.DogumTarihi.Year;
        }
        public DateTime DogumTarihi
        {
            get => _dogumTarihi;
            set
            {
                _dogumTarihi = value;

            }



        }
    }
}



