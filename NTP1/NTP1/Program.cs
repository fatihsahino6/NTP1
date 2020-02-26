using System;

namespace NTP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("1. sayi");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("2. sayi");
            //    int sayi2 = int.Parse(Console.ReadLine());
            //    int toplam = Topla(sayi1, sayi2);
            //    int carpma = Carpma(sayi1, sayi2);
            //    Console.WriteLine(toplam);
            //    Console.WriteLine(carpma);
            //    Console.ReadKey();

            //}
            //static int Topla(int s1, int s2)
            //{
            //    return s1 + s2;
            //}
            //static int Carpma(int c1, int c2)
            //{
            //    return c1 * c2;
            //}
            //static int Topla(int s1, int s2, int s3)
            //{
            //    return s1 + s2 + s3;
            //}

            //Console.WriteLine("Kaç Sayı girmek istiyorsunuz");
            //byte sayi= byte.Parse(Console.ReadLine());
            //int[] dizi =new int [sayi];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Sayilari girin");
            //    dizi[i] = int.Parse(Console.ReadLine());

            //}
            //int toplama = Topla(dizi);

            //static int Topla(int[] dizi)
            //{

            //    int toplam = 0;
            //    for (int i = 0; i < dizi.Length; i++)
            //    {
            //        toplam += dizi[i];
            //    }
            //    return toplam;
            //}

            //Console.WriteLine(toplama);


            Ev evim = new Ev();
            evim.alan = 120;
            evim.katno = 3;
            evim.odasayisi = 5;
            evim.semt = "Semt";
            Ev Ev = new Ev
            {
                alan = 100,
                katno = 3,
                odasayisi=5,
                semt="Çubuk"
                
            };
            

            Console.WriteLine(evim.EvBilgileri());

            
            Console.ReadKey();

           
        }
        
    }
    class Ev
    {
        public double alan;
        public int odasayisi;
        public string semt;
        public int katno;
        public string EvBilgileri()
        {
            return $"Alan:{this.alan}\n" +
                $"Oda Sayısı: {this.odasayisi}\n" +
                $"Kat No:{this.katno}\n" +
                $"Semt:{this.semt}";
        }

    }
}
