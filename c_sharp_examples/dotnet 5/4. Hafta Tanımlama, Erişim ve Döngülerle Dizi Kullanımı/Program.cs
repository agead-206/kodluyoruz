using System;

namespace _4._Hafta_Tanımlama__Erişim_ve_Döngülerle_Dizi_Kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanimlama
            String [] renkler = new string[5];
            String [] hayavanlar = {"kedi","kopek","kus","maymun"};

            int [] dizi;
            dizi = new int[5];

            //Dizilere deger atma
            renkler[0] = "mavi";
            dizi[3] = 10;

            // Dizilere eresim

            Console.WriteLine(hayavanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            //Dongulerle dizi dullanimi
            // klaviyeden dizi boyutu be icerigi alinacak sonra ortalama yazilacak

            Console.WriteLine("Lutfen dizinin boyutunu giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new  int[diziUzunlugu];

            for(int i=0;i<diziUzunlugu;i++)
            {
            Console.WriteLine("Lutfen {0}. sayisi giriniz",i+1 );
            sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam+=sayi;

            Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);

    }
}
}