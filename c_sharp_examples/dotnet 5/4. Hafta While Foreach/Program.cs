using System;

namespace _4._Hafta_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //  1 den baslayarak console'dan girilen sayiya kadar(sayi dahil) ortalama hesapla ve yazdir
            Console.WriteLine("Lutfen bir sayi giriniz");
           
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1;
            int toplam =0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            
            Console.WriteLine("Ortalma = "+toplam/sayi);

            // a dan z ye kadar harfleri yazdir

            char character = 'a';
            while (character <='z')
            {
            Console.WriteLine(character);
            character++;
            }
            Console.WriteLine("****Foreach****");

            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
            Console.WriteLine(araba);
            }


        }
    }
}
