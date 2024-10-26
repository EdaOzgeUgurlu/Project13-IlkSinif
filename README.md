# Project13_IlkSınıf

Bu proje, C# dilinde yazılmış basit bir konsol uygulamasıdır. Uygulama, öğrencilerin bilgilerini tutmak ve bu bilgileri ekrana yazdırmak için tasarlanmıştır. Öğrenci bilgileri, bir `Person` sınıfı aracılığıyla yönetilmektedir. Bu uygulama, temel nesne yönelimli programlama (OOP) kavramlarını anlamak için bir örnek teşkil etmektedir.

## Proje Açıklaması

Bu uygulama, kullanıcıların öğrenci bilgilerini girmesine ve bu bilgileri ekrana yazdırmasına olanak tanır. Uygulama, `Person` adında bir sınıf oluşturarak her bir öğrencinin adı, soyadı ve doğum tarihini saklar. Kullanıcı, program çalıştığında her öğrencinin bilgilerini konsolda görebilir.

## Özellikler

- Öğrenci bilgilerini (isim, soyisim, doğum tarihi) saklayabilme.
- Bilgileri konsola formatlı bir şekilde yazdırabilme.
- Basit ve kullanıcı dostu bir arayüz.

## Teknik Gereksinimler

- .NET SDK (minimum sürüm 5.0)
- Visual Studio, Visual Studio Code veya başka bir C# geliştirme ortamı.

## Kullanım

1. Projeyi indirin veya klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/Project13_IlkSınıf.git
   ```
   
2. Proje klasörüne gidin:
   ```bash
   cd Project13_IlkSınıf
   ```
   
3. Visual Studio veya benzeri bir IDE ile projeyi açın.
4. Projeyi çalıştırın. Konsol penceresinde öğrencilerin bilgileri görüntülenecektir.

## Kod Yapısı

### Person Sınıfı

- **Özellikler**:
  - `Name`: Öğrencinin adı (string).
  - `Surname`: Öğrencinin soyadı (string).
  - `Birth`: Öğrencinin doğum tarihi (DateTime).

- **Metotlar**:
  - `InformationWrite()`: Öğrencinin bilgilerini formatlı bir şekilde konsola yazdırır.

#### Örnek Person Sınıfı Kodu:

```csharp
public class Person
{
    public string name;    // Öğrencinin adı
    public string surname; // Öğrencinin soyadı
    public DateTime birth; // Öğrencinin doğum tarihi

    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birth { get; set; }

    public void InformationWrite()
    {
        Console.WriteLine($"Adı: {name}, Soyadı: {surname}, Doğum Tarihi: {birth.ToString("dd/MM/yyyy")}");
    }
}
```

### Program Sınıfı

- **Main Metodu**:
  - Uygulamanın başlangıç noktasıdır.
  - Dört adet `Person` nesnesi oluşturur ve her birine isim, soyisim ve doğum tarihi atar.
  - `InformationWrite` metodu kullanılarak bilgileri ekrana yazdırır.

#### Örnek Program Sınıfı Kodu:

```csharp
internal class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person();
        Person person3 = new Person();
        Person person4 = new Person();

        // Öğrencilerin bilgileri
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

        // Bilgileri yazdır
        person1.InformationWrite();
        person2.InformationWrite();
        person3.InformationWrite();
        person4.InformationWrite();

        Console.ReadKey();
    }
}
```

## Geliştirme Süreci

1. **Proje Planlaması**: Projenin temel ihtiyaçları ve amaçları belirlendi.
2. **Sınıf Tasarımı**: `Person` sınıfı oluşturuldu ve gerekli özellikler tanımlandı.
3. **Ana Program Geliştirme**: Öğrenci nesneleri oluşturuldu ve bilgiler konsola yazdırıldı.
4. **Test**: Program çalıştırılarak çıktıların doğruluğu kontrol edildi.

