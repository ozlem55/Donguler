using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar tek sayıları yazdırma
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i =1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
           
            }
            //1-1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana verir
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Çift Toplam:" + ciftToplam);

            //break,continue
            for (int i =  1; i <= 0; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 0; i++)
            {
                if (i == 4)
                   continue;
                Console.WriteLine(i);
            }
        }
    }
}
