using System;

namespace KullanicidanNesneAlma
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
            ogr.bolum = Console.ReadLine();
            Console.WriteLine("Öğrenci Numaranızı Giriniz");
            ogr.okulno = int.Parse(Console.ReadLine());
            Console.WriteLine("Yaşınızı Giriniz");
            ogr.yas = Convert.ToInt32(Console.ReadLine());
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
