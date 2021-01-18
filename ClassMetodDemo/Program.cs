using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Özkan";
            musteri1.Soyad = "Demircan";
            musteri1.Iban = "123456789";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Murat";
            musteri2.Soyad = "Öztürk";
            musteri2.Iban = "123456753";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ensar";
            musteri3.Soyad = "Çetin";
            musteri3.Iban = "123456756";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("ABC BANKASI TAKİP SİSTEMİ");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Iban);

                Console.WriteLine("----------------");



            }

            Console.WriteLine("-------EKLEME---------");

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);






            Console.WriteLine("-------SİLME---------");

            musteriManager.Sil(musteri2);


            Console.WriteLine("-------LİSTELE---------");





        }
    }
}
