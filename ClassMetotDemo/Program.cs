using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Tankut";
            musteri1.SoyAdi ="Dağdelen";
            musteri1.Sirketi ="Formadditive";
            musteri1.MailAdresi = "tankut@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Bülent";
            musteri2.SoyAdi = "Hor";
            musteri2.Sirketi = "Formadditive";
            musteri2.MailAdresi = "bulent@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Yiğit";
            musteri3.SoyAdi = "Baş";
            musteri3.Sirketi = "Formadditive";
            musteri3.MailAdresi = "yigit@gmail.com";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Add(musteri);
            }

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.List(musteri);
            }

        }
    }
}
