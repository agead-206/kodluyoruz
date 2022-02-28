using System;

namespace _4._Hafta_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak ayindasinz!");
                break;
                case 2:
                Console.WriteLine("Subat ayindasinz!");
                break;
                case 4:
                Console.WriteLine("Nisan ayindasinz!");
                break;
                case 3:
                Console.WriteLine("Mart ayindasinz!");
                break;

                default:
                Console.WriteLine("Yanlis veri!");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kis ayindasiniz!");
                    break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("Ilkbahar ayindasiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz ayindasiniz!");
                    break;    
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar ayindasiniz!");
                    break;
                default:
                    break;
            }
        }
    }
}
