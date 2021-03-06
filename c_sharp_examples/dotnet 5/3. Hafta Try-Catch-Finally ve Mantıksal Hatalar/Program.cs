using System;

namespace _3._Hafta_Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    class Program
    {
       
        static void Main(string[] args)
        {
             try
        {
            Console.WriteLine("sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi: " + sayi);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message.ToString());           
        }
        finally {
            Console.WriteLine("Islem tamamlandi.");
        }

        {
             try
        {
            //int a = int.Parse(null);
            // int a = int.Parse("test");
            int a = int.Parse("-12345678910");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Bos deger girdiniz");  
            Console.WriteLine(ex);           
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun degil");  
            Console.WriteLine(ex);           
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("cok kutcut veya cok buyuk bir deger girdiniz");  
            Console.WriteLine(ex);           
        }
        finally {
            Console.WriteLine("ikinci islem tamamlandi");  
        }
        }
    }
}
}