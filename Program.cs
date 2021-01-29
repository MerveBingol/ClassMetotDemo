using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Merve";
            musteri1.LastName = "BİNGÖL";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Nuri";
            musteri2.LastName = "AKSU";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.FirstName = "Ece";
            musteri3.LastName = "ÖZ";

            List<Musteri> musteriler = new List<Musteri>() { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Listeler(musteriler);

            

            Console.WriteLine(" \n " + "Hangi Müşteriyi silmek istersiniz Id 'sini giriniz lütfen  ?");
            int yaz = Convert.ToInt32(Console.ReadLine());

            musteriManager.Delete(yaz,musteriler);
           
            Console.WriteLine("\n"+yaz+" silindikten sonra yeni Liste");

            musteriManager.Listeler(musteriler);
        }
    }
}
