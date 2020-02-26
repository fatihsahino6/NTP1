using System;

namespace NTP2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine();
            ogr.ad = "Mehmet Fatih";
            ogr.soyad = "Şahin";
            ogr.bolum = "Bilgisayar Programcılığı";
            ogr.okulno = 193801046;
            ogr.yas = 24;
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
