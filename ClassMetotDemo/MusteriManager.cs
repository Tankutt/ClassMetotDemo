using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+" No'lu müşteri kaydı gerçekleştirilmiştir. "+ musteri.Adi+" "+ musteri.SoyAdi);
        }

        public void List(Musteri musteri)
        {          
            Console.WriteLine(musteri.Id + " No'lu müşteri: " + musteri.Adi + " " + musteri.SoyAdi );
        }

        public void Clear(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " No'lu müşteri kaydı silinmiştir.");
        }
    }
}
