using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Yas = 35;
            musteri1.bossatir = " ";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Arda";
            musteri2.Soyadi = "Şanlıer";
            musteri2.Yas = 15;
            musteri2.bossatir = " ";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Yılmaz";
            musteri3.Yas = 51;
            musteri3.bossatir = " ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            /*foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine("İsmi: " + musteri.Adi);
                Console.WriteLine("Soyismi: " + musteri.Soyadi);
                Console.WriteLine("Yaşı: " + musteri.Yas);
                Console.WriteLine(musteri.bossatir);
            }*/

            Console.WriteLine("-----------Profiliniz Oluşturuluyor-----------------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("----------------Müşterilerimiz-----------------------");
            musteriManager.List(musteri1);
            musteriManager.List(musteri2);
            musteriManager.List(musteri3);

            Console.WriteLine("---------------Profiliniz Siliniyor------------------");
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
        }
    }
}
