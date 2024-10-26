using System; // System kütüphanesini ekleyerek temel sınıfları ve fonksiyonları kullanmamıza olanak tanır.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13_IlkSınıf 
{
    internal class Person // Sınıftaki öğrencilerin bilgilerini tutmak için sınıf oluşturuldu.
    {
        public string name;    // Öğrencinin adı için değişken tanımlandı.
        public string surname; // Öğrencinin soyadı için değişken tanımlandı.
        public DateTime birth; // Öğrencinin doğum tarihi için DateTime tipi değişken tanımlandı.

        public string Name // İsim işlemleri için özellik (property).
        {
            get // İsim değeri alınırken kullanılacak olan get
            {
                return name; // Değişkenin değerini döndür.
            }
            set // İsim değeri atanırken kullanılacak olan set
            {
                name = value; // Atanan değeri değişkene kaydet.
            }
        }

        public string Surname 
        {
            get 
            {
                return surname; 
            }
            set 
            {
                surname = value; 
            }
        }

        public DateTime Birth 
        {
            get 
            {
                return birth; 
            }
            set 
            {
                birth = value; 
            }
        }

        public void InformationWrite() // Verileri ekrana yazdırmak için metot.
        {
            // Kişinin bilgilerini konsola yazdır.
            Console.WriteLine($"Adı: {name} / Soyadı: {surname} / Doğum Tarihi: {birth.ToString("dd/MM/yyyy")}");
        }
    }
}