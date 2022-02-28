using System;

namespace _4._Hafta_Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sort
            int [] sayiDizisi ={23,12,4,86,72,3,11,17};
            Console.WriteLine("****Sirasiz Dizi****");
            foreach (var sayi in sayiDizisi)
            {
            Console.WriteLine(sayi);
            }
            Console.WriteLine("****Sirali Dizi****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
            Console.WriteLine(sayi);
            }

            // Clear 
            //verdigimiz index tan baslayarak verdigimiz eleman sayisi kadar elemenlari sifirliyor
            Console.WriteLine("****Array Clear****");
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
            Console.WriteLine(sayi);
            }

            // Reverse son elemani ilk eleman ile degistiriyor
            Console.WriteLine("****Reverse Array ****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
            Console.WriteLine(sayi);
            }

            //indexOf 
            Console.WriteLine("**** ArrayindexOf ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize 
            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=90;
            foreach (var sayi in sayiDizisi)
            {
            Console.WriteLine(sayi);
            }
        }
    }
}
