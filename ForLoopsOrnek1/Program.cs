using System;

namespace ForLoopsOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOr Örnek");

            // Kullanıcıya kaç sayı girileceği sorulacak, giriş yaptğı sayı kadar asyı istenip toplanacak...
            Console.WriteLine("Kaç adet sayı girilecek????");

            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. Sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi; // kendisiyle topla...
            }

            Console.WriteLine($"girilen sayıların toplamı = {toplam}");

            Console.WriteLine("*********************************");

            toplam = 0; // toplamı sıfırlıyoruz...
            int j = 0;
            while (j < n)
            {
                Console.WriteLine($"{j + 1}. Sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi; // kendisiyle topla...
                j++;
            }

            Console.WriteLine($"girilen sayıların toplamı = {toplam}");
            Console.ReadKey();
        }
    }
}