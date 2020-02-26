using System;

namespace MethodOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar pc = new Bilgisayar();
            Console.WriteLine("Bilgisayarınızın Modelini Giriniz");
            pc.model = Console.ReadLine();
            Console.WriteLine("Anakart Modelini Giriniz");
            pc.anakart = Console.ReadLine();
            Console.WriteLine("Ram Boyutunu Giriniz");
            pc.ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ekran Karti Boyunu Giriniz");
            pc.ekran_karti = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harddisk Boyutunu Giriniz");
            pc.harddisk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlemci İsmini Giriniz");
            pc.islemci_adi = Console.ReadLine();
            Console.WriteLine("İşlemci Neslini Giriniz");
            pc.islemci_nesili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pc.Bilgisayar_Bilgileri());
            Console.ReadKey();
        }
    }
    class Bilgisayar
    {
        public string model;
        public string anakart;
        public int ram;
        public int ekran_karti;
        public int harddisk;
        public string islemci_adi;
        public int islemci_nesili;

        public string Bilgisayar_Bilgileri()=> $"Bilgisayar Modeli: {this.model}\n Bilgisayar Anakartı İsmi: {this.anakart}\nRam Boyutu :{this.ram}\nEkran Karti Boyutu: {this.ekran_karti}\nHarddisk Boyutu : {this.harddisk}\nİşlemci Adı : {this.islemci_adi}\nİşlemci Nesli : {this.islemci_nesili}";
        
    }
}
