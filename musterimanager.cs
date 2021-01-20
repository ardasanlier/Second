using System;
using System.Collections.Generic;
using System.Text;

namespace Second
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldiniz Sayın " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine(musteri.bossatir);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Güle Güle Sayın " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine(musteri.bossatir);
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("İsmi: " + musteri.Adi);
            Console.WriteLine("Soyismi: " + musteri.Soyadi);
            Console.WriteLine("Yaşı: " + musteri.Yas);
            Console.WriteLine(musteri.bossatir);
        }
    }
}
