using System;

namespace loopsjumpifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu üç komutun ortak özelliği alt satırdaki komutları çalıştırmamasıdır....
            // continue (sadece döndüde kullanlır) = altındaki komutları çalıştırmadan döndüde bir sonraki adıma geçmek için kullanılır...
            // break; (switch ve döngü) = // döngüden çıkmak için kullanılır...
            // return (heryerde)  = altındaki hiç bir komutu çalıştırmaz... 
          
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                //if (i == 5)
                //    continue;
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("************************");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine($"{i}");
            }


            Console.ReadKey();
        }
    }
}
