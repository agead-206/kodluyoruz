using System;

namespace _3._hafta_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Atama ve islemli atama
            Console.WriteLine("********Atama ve islemli atama"); 

            int x = 3;
            int y = 3;

            y=y+2;
            Console.WriteLine(y);

            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            // mantiksal operatorler
            // ||, &&, !

             Console.WriteLine("********mantiksal operatorler");  

            bool isSuccess = true;
            bool isComplated = false;

            if(isSuccess && isComplated)
            Console.WriteLine("Perfect"); 

            if(isSuccess || isComplated)
            Console.WriteLine("Great"); 

            if(isSuccess && !isComplated)
            Console.WriteLine("Fine"); 

            // Iliskilsel operatorler
            // <, >, <=, >=, ==, !=
            Console.WriteLine("********Iliskilsel operatorler"); 
 
            int a =3;
            int b =4;
            bool  sonuc=a<b;
            Console.WriteLine(sonuc); 
            sonuc = a>b;
            Console.WriteLine(sonuc); 
            sonuc = a>= b;
            Console.WriteLine(sonuc); 
            sonuc = a<= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a!= b;
            Console.WriteLine(sonuc);

            // Aritmatik operatorler
            // +, -, *, /
            Console.WriteLine("********Aritmatik operatorler");     
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/ sayi2;
            Console.WriteLine(sonuc1); //2
            sonuc1 = sayi1* sayi2;
            Console.WriteLine(sonuc1);//50
            sonuc1 = sayi1+ sayi2;
            Console.WriteLine(sonuc1);//15
            sonuc1 = sayi1/ sayi2;
            Console.WriteLine(sonuc1);//2
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);//11
            // mod %
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);//2
            
        }
    }
}
