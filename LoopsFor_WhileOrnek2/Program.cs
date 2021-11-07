using System;

namespace LoopsFor_WhileOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             while(kosul)
            {
            }
            */
            Console.WriteLine("Çarpım tablosu.....!");

            Console.WriteLine("Kaçlara kadar çarpmak istiyorsunuz...Min 1 Max. 10 giribilirsiniz....");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        int sonuc = i * j;
                        Console.WriteLine($"{i} * {j} = {sonuc}");
                    }

                    Console.WriteLine("**********************");
                }
            }
            else
            {
                Console.WriteLine("Girilen sayı değer aralığının dışandaydı...");
            }


            if (n >= 1 && n <= 10)
            {
                int i = 1;
                int j = 1;

                while (i <= 10)
                {
                    while (j <= 2)
                    {
                        int sonuc = i * j;
                        Console.WriteLine($"{i} * {j} = {sonuc}");
                        j++;
                    }
                    j = 1; // döngüden çıktığında j'yi resetle...
                    i++;
                }
            }

            Console.ReadKey();
        }
    }
}
