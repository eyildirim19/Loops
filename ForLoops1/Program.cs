using System;

namespace ForLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döngü => bir kod veya kod bloğunun tekrar çalışmasını sağlayan program bloklarıdır... 3 döngü ilede biribirinin aynı işlemler yapılabilir.. sadece döngülerin koşullara göre yazım kolylığı vardır..

            /// for döngüsü => başlangıç ve bitiş değeri üzeinden çalışan döngüdür...

            //  bu iki döngü koşullu döngü olarak bilinir. koşul sağlanınyaca kadar çalışır...
            // while
            // dowhile 
            // foreach => c# özel dizilerde kullanılar döngülerdir. Daha sonra (dizilerden) inceleyeceğiz...
            // Ekrana 10 defa Merhaba C# mesajı verdirelim....


            /*
             * döngülerin ön önemli özelliği kod tekrarını engellemektir..
                for(başlangıc; koşul; artimveyazalim)
                {
                        tekrar çalışacak komutlar... d
                }

            önce başlangıçdeğeri set edilir. sonra konşula bakılır. sonra döngü komutları çalıştırılır. sonra artım yapılır. sonra koşula bakılır. sonra döngü komutları çalıştırılır. sonra artım yapılır. sonra koşula bakılır. süreç koşul sağlanana kadar devam eder...

             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba c#");
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i inin değer {i}");
            }


            int j = 0;
            for (; j < 5;)
            {
                Console.WriteLine($"dönüyoruz... {j + 1}");
                j++;
            }

            Console.ReadKey();
        }
    }
}
