using System;

namespace VizeFinalOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            Console.WriteLine("Öğrenci Sayısını Giriniz  ");

            n = Convert.ToInt32(Console.ReadLine());

            // En yük ve EN DÜşük ortalama sahip kullanıcının sırasını ekrana yazdırınız...

            float enkOrtalama = 100, enbOrtalama = 0, toplamOrtalama = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}. öğrenci vizesi");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{i + 1}. öğrenci finali");
                float final = Convert.ToSingle(Console.ReadLine());

                float ortalama = (vize * 0.4f) + (final * 0.6f);

                Console.WriteLine($"Öğrenci Ortalaması = {ortalama}");


                if (ortalama > enbOrtalama) // if bloğunda tek satır komutunuz varsa scope açmanıza gerekyok...
                    enbOrtalama = ortalama;


                if (ortalama < enkOrtalama)
                    enkOrtalama = ortalama;

                toplamOrtalama += ortalama;
            }

            toplamOrtalama = toplamOrtalama / n;

            Console.WriteLine($"Sınıf Ortalaması = {toplamOrtalama}");
            Console.WriteLine($"En büyük Öğrenci Ortalaması = {enbOrtalama}");
            Console.WriteLine($"En küçük Öğrenci Ortalaması = {enkOrtalama}");

            Console.ReadKey();
        }
    }
}