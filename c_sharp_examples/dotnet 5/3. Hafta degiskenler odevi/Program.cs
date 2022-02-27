using System;

namespace _3._Hafta_degiskenler_odevi
{
    class Program
    {
        static void Main(string[] args)
        { 
            // atama icin null yapilababilir
/*
            byte byte_degisken = 5; // 1 byte pozetif tam sayi
            sbyte sbyte_degisken =-10; // 1 byte tam sayi
            short short_degisken = -1000; // 2 byte tam sayi
            ushort unsigned_short = 1242; // 2 byte pozetif tam sayi
            int16 tamsayi_16 = 2; // 2 byte tam sayi
            int tamsayi = 23; // 4 byte tam sayi
            Int32 tamsayi_32 = 42; // 4 byte tam sayi
            Int64 tamsayi_64 = 23; // 8 byte tam sayi
            long long_int = 345; // 8 byte 
            ulong unsigned_long = 34; // 8 byte pozetif tam sayi

            float real = 3; // 4 byte real
            double buyuk_real = 4 ; // 8 byte real
            decimal extra_buyuk_real = 3; // 16 byte real

            char karekter = '3'; // 2 byte karekter
            string metin = "ornek"; //sinirsiz (char*2 byte)

            bool mantiksal = true; // true or false

            DateTime DT =  DateTime.Now; // tarih ve saat

            object o1= "3"; // her turlu deger tutabilir
*/

           // string ifadeler

            string str1 = "";
            string str2 = null;
            string str3 = string.Empty;
            str1 = "Agyad SEMSEDDIN";
            string name = "Agyad";
            string surname = "SEMSEDDIN";
            string full_name = name + " " + surname;
            
            // integer ornekleri

            int int1 = 5;
            int int2 = 3;
            int int3 = int1*int2;
                
             // Boolean
            
            bool b1 = 5<2;

            //degisken donusumleri

            string str10 = "10";
            int int10 = 10;
            string yeni = str10 + int10.ToString();

            Console.WriteLine(yeni);

            int int20 = int10 + Convert.ToInt32(str10);
            Console.WriteLine(int20);

            int int22 = int10 + int.Parse(str10) + 2; // parse converts string to int

            // datetime 

            string  datetime = DateTime.Now.ToString("dd.mm.yyyy"); 
            // DateTime.Now.to converts to another types
            //     you can get a specific date output by useing notations like dd/mm/yyyy or HH.mm
        }
    }
}
