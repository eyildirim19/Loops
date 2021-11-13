using System;
using System.Threading;

namespace UserLoginOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 0;
            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz....");
                string kadi = Console.ReadLine();

                Console.WriteLine("Şifrenizi Giriniz");
                string sifre = Console.ReadLine();

                if (kadi.ToLower() == "admin" && sifre.ToLower() == "123")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{++hak}. kez hatalı giriş yaptınız. Kalan giriş hakkınız {3 - hak}");

                }

                if (hak == 3) // hak 3 ise
                {
                    Console.WriteLine("hatalı giriş yaptınız çıkıyorsunuz.....");
                    Thread.Sleep(4000);// iki saniye bekle...
                    //Console.ReadKey();
                    return; // program metodundan çık...
                }

            } while (hak < 3);


            Console.WriteLine("Hoş geldin admin.......");
            Console.ReadKey();
        }
    }
}
