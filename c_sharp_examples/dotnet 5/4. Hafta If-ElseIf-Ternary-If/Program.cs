using System;

namespace _4._Hafta_If_ElseIf_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time <11)
                Console.WriteLine("Gunaydin");
            else if (time <=18)
                Console.WriteLine("Iyi gunler");
            else 
                Console.WriteLine("Iyi gecler");
            

            String  sonuc =time<= 6 &&time <= 11 ? "gunaydin" : time<=18 ? "iyi gunler" : "iyi geceler"; 
                Console.WriteLine(sonuc);

        }
    }
}
