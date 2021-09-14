using System;

namespace ClassMetotDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesap hesap1 = new Hesap();
            {
                hesap1.kullaniciAdi = "TonBaligi";
                hesap1.hesapLvl = 216;
                hesap1.rp = 0;
                hesap1.maviOz = 7468;
            }

            Hesap hesap2 = new Hesap();
            {
                hesap2.kullaniciAdi = "Damıen";
                hesap2.hesapLvl = 146;
                hesap2.rp = 215;
                hesap2.maviOz = 4365;
            }

            Hesap[] hesaplar = new Hesap[] { hesap1, hesap2};

            HesapManager hesapManager = new HesapManager();
            hesapManager.Giris(hesap1);
            hesapManager.Giris(hesap2);
            Console.WriteLine(" ");
            hesapManager.Cıkıs(hesap1);
            hesapManager.Cıkıs(hesap2);
            Console.WriteLine(" ");
            hesapManager.HesapBilgileri(hesap1);
            Console.WriteLine(" ");
            hesapManager.HesapBilgileri(hesap2);

        }
    }
}
