using System;

namespace _4._Hafta_For_Loop_ve_Break_Continue_Ifadeleri

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen bir sayi giriniz!");
            // Girilen sayiya kadar tek sayilari ekrana yazdir.
            int sayac = int.Parse(Console.ReadLine());

            for(int i=0; i<= sayac ;i++)
            {
                if (i%2==1)
                Console.WriteLine(i);
            }
            // 1 ile 1000 arasinidaki cift ve tek sayilarin toplami ekrana yazdir.
            int tek_toplam =0;
            int cift_toplam =0;

            for(int i=0; i<=1000 ;i++)
            {
                if (i%2==1)
                tek_toplam +=i;
                else
                cift_toplam+=i;

            }
            Console.WriteLine("Tek toplam = "+tek_toplam);
            Console.WriteLine("Cift toplam = "+cift_toplam);

            //Break , Continue
             for(int i=0; i<10 ;i++)
            {
                if (i==4)
                break;                
                
            Console.WriteLine(i);

            }  
            for(int i=0; i<10 ;i++)
            {
            {
                if (i==4)
                continue;                
                
            Console.WriteLine(i);

            }  
            }
        }
    }
}
