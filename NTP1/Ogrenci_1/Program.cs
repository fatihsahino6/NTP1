using System;

namespace Ogrenci_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("Adınızı Giriniz");
            ogr.ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            ogr.soyad = Console.ReadLine();
            Console.WriteLine("Bölümünüzü Giriniz");
            ogr.bolum = "Bilgisayar Programcılığı";
            Console.WriteLine("Öğrenci Numaranızı Giriniz");
            ogr.okulno = int.Parse(Console.ReadLine());
            Console.WriteLine("Yaşınızı Giriniz");
            ogr.yas = int.Parse(Console.ReadLine());
            Console.WriteLine(ogr.Ogrenci_Bilgileri());
            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        public string ad;
        public string soyad;
        public int okulno;
        public string bolum;
        public int yas;
        public string Ogrenci_Bilgileri() => $"Adi: {this.ad}\n Soyadi: {this.soyad}\nOkul Numarası :{this.okulno}\nBölümü: {this.bolum}\nYaşı : {this.yas}";




    }
}
