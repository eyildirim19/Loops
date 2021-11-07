using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do while!");

            /*
                do{
                    <islemler>
                }while(<kosul>);

            Diper iki döngüden farklı çalışır....Diğer döngüler kodları çalışmatarmak için önce koşula bakar. Koşul sağlandığında döngü çalışır.

            Do While döngüsü ise önce kodu çalıştırır sonra işlem yapar...bu yapı koşul sağlanana kadar devam eder...

            Do While döngüsü koşul sağlansın sağlanmasın bir kere çalışır. sağlanırsa çalışmaya devam eder, eğer sağlanmazsa döngünden çıkar...

             */

            while (false)
            {
                Console.WriteLine("merhaba while");
            }

            do
            {
                Console.WriteLine("merhaba doo....");
            } while (false);

            int sayac = 0;
            do
            {
                Console.WriteLine($"dönüyoruz {sayac++}");
            } while (sayac < 10);

            Console.ReadKey();
        }
    }
}
