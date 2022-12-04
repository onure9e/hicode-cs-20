using System;

namespace acces_pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ali";
            calisan1.Soyad = "Veli";
            calisan1.No = 110;
            calisan1.Departman = "1. Departman";

            calisan1.CalisanBilgileri();
            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Veli";
            calisan2.Soyad = "Ali";
            calisan2.No = 111;
            calisan2.Departman = "2. Departman";

            calisan2.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: "+ Ad);
            Console.WriteLine("Çalışan Soyadı: "+ Soyad);
            Console.WriteLine("Çalışan No: "+ No);
            Console.WriteLine("Çalışan Departmanı: "+ Departman);
        }
    }
}