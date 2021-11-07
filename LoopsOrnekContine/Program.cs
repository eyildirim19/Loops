using System;


namespace LoopsOrnekContine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Kaç adet sayı çift gireceksiniz");
            int n = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;

            // kullanıcı çift sayı girene kadar sayıyı isteyelim....
            // girilen çift sayılarında en büyüğünü bulalım..

            int enb = -1;// en büyük...
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"lütfen {i + 1}. çift sayınızı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int sonuc = sayi % 2; // 2'ye bölümden kalanı verir...
                if (sonuc != 0) // sayı tek olduğunda sayacı geri çek tekrar sayıyı iste....
                {
                    i--; //i'yi azalt....
                    continue; //i'yi arttırmaya gider...
                }

                if (sayi > enb) // girilen sayı büyükse enb.'den 
                {
                    enb = sayi; // sayı en büyüktür...
                }

                toplam += sayi;
            }

            Console.WriteLine($"girilen sayıların toplamı....{toplam}");
            Console.WriteLine($"girilen sayıların en büyüğü....{enb}");
            Console.ReadKey();
        }
    }
}
