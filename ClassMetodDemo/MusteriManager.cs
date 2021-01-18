using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad+ " isimli " + musteri.Iban + " İban burda müşteri müşteride eklenmiştir ");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad +" isimli "   + musteri.Iban + " İban burada müşteri bankacılık sisteminden silinmiştir. ");

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad + " - " + musteri.Iban);
        }

    }
}
