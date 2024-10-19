using System;
using System.Collections.Generic;

public class Araba
{
    // Arabanın üretim tarihi otomatik olarak oluşturulurken atanacak
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; } // Benzersiz bir seri numarası
    public string Marka { get; set; } // Arabanın markası (ör: BMW, Toyota)
    public string Model { get; set; } // Arabanın modeli (ör: Corolla, X5)
    public string Renk { get; set; } // Arabanın rengi
    public int KapiSayisi { get; set; } // Arabanın kaç kapısı olduğu bilgisi

    // Constructor: Yeni bir araba oluşturulduğunda üretim tarihi o anın zamanı olacak
    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Birden fazla araba üretileceği için arabalar listesi oluşturuyoruz
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        // Kullanıcıya araba üretmek isteyip istemediğini soracağız, ve bu süreç döngüde devam edecek
        do
        {
            Console.WriteLine("Araba üretmek ister misiniz? (Evet için 'e', Hayır için 'h' tuşuna basınız): ");
            cevap = Console.ReadLine().ToLower(); // Küçük-büyük harf duyarlılığını ortadan kaldırıyoruz

            if (cevap == "e")
            {
                // Evet cevabı alırsak bir araba üretip listeye ekliyoruz
                Araba yeniAraba = ArabaUret();
                arabalar.Add(yeniAraba);
                Console.WriteLine("Araba başarıyla üretildi.");
            }
            else if (cevap != "h")
            {
                // Eğer geçersiz bir cevap verilirse kullanıcıyı uyarıyoruz
                Console.WriteLine("Geçersiz cevap, lütfen 'e' veya 'h' ile yanıt veriniz.");
            }
        } while (cevap != "h"); // Hayır cevabı alana kadar döngü devam eder

        // Kullanıcı hayır dediğinde döngü sonlanır ve üretilen arabalar listelenir
        Console.WriteLine("Üretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }

    // Bu metod, yeni bir araba nesnesi oluşturmak için kullanılır
    static Araba ArabaUret()
    {
        Araba araba = new Araba();

        // Kullanıcıdan arabayla ilgili özellikleri isteyeceğiz
        Console.Write("Seri Numarası: ");
        araba.SeriNumarasi = Console.ReadLine();

        Console.Write("Marka: ");
        araba.Marka = Console.ReadLine();

        Console.Write("Model: ");
        araba.Model = Console.ReadLine();

        Console.Write("Renk: ");
        araba.Renk = Console.ReadLine();

    // Kapı sayısını kullanıcıdan alırken hatalı girişleri kontrol edeceğiz
    KapilariGir:
        try
        {
            Console.Write("Kapı Sayısı: ");
            araba.KapiSayisi = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            // Kullanıcı hatalı bir giriş yaptığında, onu uyarıp tekrar soruyoruz
            Console.WriteLine("Hatalı giriş! Lütfen sayısal bir değer giriniz.");
            goto KapilariGir; // Hatalı girişte tekrar aynı satıra dön
        }

        return araba; // Araba nesnesi başarıyla oluşturulmuş oluyor
    }
}
