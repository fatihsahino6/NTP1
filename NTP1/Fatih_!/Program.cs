using System;

namespace Fatih__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sayiyi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayiyi giriniz");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ne Yapmak İstiyorsunuz ? 1:Toplama 2:Çıkarma 3:Çarpma 4:Bölme");
            byte islem = byte.Parse(Console.ReadLine());
            if (islem==1)
            {
                Console.WriteLine(Topla(sayi1, sayi2));
            }
            else if(islem==2)
            {
                Console.WriteLine(Cikar(sayi1, sayi2));
            }
            else if(islem==3)
            {
                Console.WriteLine(Carp(sayi1, sayi2));
            }
            else if(islem==4)
            {
                Console.WriteLine(Bolme(sayi1,sayi2));
            }
            static int Topla(int s1, int s2)
            {
                return s1 + s2;
            }
            static int Cikar(int s1, int s2)
            {
                return s1 - s2;
            }
            static int Carp(int s1, int s2)
            {
                return s1 * s2;
            }
            static int Bolme(int s1, int s2)
            {
                return s1 / s2;
            }

            Console.ReadKey();
        }
    }
}
