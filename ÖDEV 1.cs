using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ { }
public class Kisi
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public string TCKimlikNo { get; set; }
    public List<Arac> Araclar { get; set; }

    public Kisi()
    {
        Araclar = new List<Arac>();
    }
}

public class Arac
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
    public string Marka { get; set; }
    public DateTime EdinmeTarihi { get; set; }
    public decimal EdinmeFiyati { get; set; }
    public string Tur { get; set; } // Taksi, Kamyon, Otobüs vb.
    public List<string> Sahipler { get; set; }

    public Arac()
    {
        Sahipler = new List<string>();
    }
}
public class Program
{
    private static List<Kisi> kisiler = new List<Kisi>();
    private static List<Arac> araclar = new List<Arac>();

    public static void Main(string[] args)
    {
        // Örnek veri ekleme
        Kisi kisi1 = new Kisi { Id = 1, Ad = "Murat", Soyad = "Taşyürek", DogumYili = 1985, TCKimlikNo = "12345678901" };
        Arac arac1 = new Arac { Id = 1, Model = "Corolla", Yil = 2020, Marka = "Toyota", EdinmeTarihi = new DateTime(2020, 1, 1), EdinmeFiyati = 150000, Tur = "Taksi" };
        arac1.Sahipler.Add("Ali Veli");
        arac1.Sahipler.Add("Ayşe Yılmaz");
        arac1.Sahipler.Add("Murat Taşyürek");

        kisi1.Araclar.Add(arac1);
        kisiler.Add(kisi1);
        araclar.Add(arac1);

        // Kişi ve araç bilgilerini yazdırma
        YazdirKisiBilgileri(kisi1);
    }

    public static void YazdirKisiBilgileri(Kisi kisi)
    {
        Console.WriteLine($"Kişi: {kisi.Ad} {kisi.Soyad}");
        Console.WriteLine($"Doğum Yılı: {kisi.DogumYili}");
        Console.WriteLine($"TC Kimlik No: {kisi.TCKimlikNo}");
        Console.WriteLine("Araçlar:");
        foreach (var arac in kisi.Araclar)
        {
            Console.WriteLine($"- {arac.Marka} {arac.Model} ({arac.Yil}) - {arac.Tur}");
            Console.WriteLine($"  Edinme Tarihi: {arac.EdinmeTarihi.ToShortDateString()}");
            Console.WriteLine($"  Edinme Fiyatı: {arac.EdinmeFiyati:C}");
            Console.WriteLine($"  Şasi Numarası: *A**9");
            Console.WriteLine($"  Sahibi: {arac.Sahipler[arac.Sahipler.Count - 1]}");
            Console.WriteLine($"  Model Yılı: {arac.Sahipler[arac.Sahipler.Count - 2]}");
        }
    }
}
