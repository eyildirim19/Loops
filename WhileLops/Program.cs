using System;

namespace WhileLops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While döngüsü!");

             /*  while(<kosul>)
                {
                    <islem>
                }
             */

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"dönüyoruz {i}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
