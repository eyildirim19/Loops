using System;

namespace LoopsDoWhileOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi, sifre;
            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz");
                kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz");
                sifre = Console.ReadLine();

                if (kullaniciAdi == "admin" && sifre == "123")
                {
                    break; // döngüyü sonlandır....
                           //  donsunMu = false;
                }
            } while (true); // hep dön...

            Console.WriteLine("Hoş geldin admin.....");
            // adminin diğer işlemleri....

            // Ödev 1: Örnekte olduğu gibi kullanıcı adı admin ve şifre 123 ise hoş geldin mesajı verilecek.. Eğer kullanıcı bilgileri hatalı girerse kullanıya 3 adet hak verilecek. 3 kere yanlış girersede uygulama sonlandırılacak...Perşembe günü 24:00 gönderiyorsunuz. ben ödevleri github linkindne kontrol edeceğim...
    
            // Ödev 2: kullanıcından öğrenci sayısı isnetecek. Öğrenci sayısı kadar vize ve final notları istenecek. öğrenci ortalamsı bulancak...
            // 1. En yüksek ortalamayı bulacaksınız...
            // 2. En düşük ortalama
            // 3. Genel Ortalama...


            Console.ReadKey();
        }
    }
}
