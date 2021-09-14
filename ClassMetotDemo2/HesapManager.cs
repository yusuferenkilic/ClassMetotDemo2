using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo2
{
    class HesapManager
    {
        public void Giris(Hesap hesaplar)
        {
            Console.WriteLine("Giriş yapıldı : " + hesaplar.kullaniciAdi);
        }

        public void Cıkıs(Hesap hesaplar)
        {
            Console.WriteLine("Çıkış yapıldı : " + hesaplar.kullaniciAdi);
        }

        public void HesapBilgileri(Hesap hesaplar)
        {
            Console.WriteLine("_Hesap Bilgileri_");
            Console.WriteLine("Hesap Adı : " + hesaplar.kullaniciAdi);
            Console.WriteLine("Hesap Seviyesi : " + hesaplar.hesapLvl);
            Console.WriteLine("Hesaptaki RP : " + hesaplar.rp);
            Console.WriteLine("Hesaptaki Mavi Öz : " + hesaplar.maviOz);
            
        }
    }
}
