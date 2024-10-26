using System; // System kütüphanesini ekleyerek temel sınıfları ve fonksiyonları kullanmamıza olanak tanır.

namespace Project13_IlkSınıf 
{
    internal class Program // Ana program sınıfı.
    {
        static void Main(string[] args) 
        {
            // Person sınıfından nesne oluşturuyoruz.
            Person person1 = new Person(); // İlk kişi nesnesi oluşturuluyor.
            Person person2 = new Person(); // İkinci kişi nesnesi oluşturuluyor.
            Person person3 = new Person(); // Üçüncü kişi nesnesi oluşturuluyor.
            Person person4 = new Person(); // Dördüncü kişi nesnesi oluşturuluyor.

            // Sınıftaki kişilerin bilgilerini oluşturuyoruz.
            person1.Name = "Cenk"; 
            person1.Surname = "Tosun"; 
            person1.Birth = new DateTime(1984, 01, 01); 

            person2.Name = "Hakan"; 
            person2.Surname = "Çalhanoğlu";
            person2.Birth = new DateTime(1985, 07, 15); 

            person3.Name = "Uğurcan"; 
            person3.Surname = "Çakır";
            person3.Birth = new DateTime(1991, 11, 20); 

            person4.Name = "Mert"; 
            person4.Surname = "Günok"; 
            person4.Birth = new DateTime(1990, 03, 25); 

            // Her bir nesnenin bilgilerini ekrana yazdırıyoruz.
            person1.InformationWrite();
            person2.InformationWrite();
            person3.InformationWrite(); 
            person4.InformationWrite(); 

            Console.ReadKey(); 
        }
    }
}