using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri) {
         
        }
        public void Delete(int yaz, List<Musteri> musteriler)
        {
            musteriler.RemoveAt(yaz-1);
           
        }

        public void Listeler(List<Musteri> musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(" \n " + " Müşteri Id: " + musteri.Id + " \n " + " Müşteri isim : " + musteri.FirstName
                   + " \n " + " Müşteri Soyad : " + musteri.LastName);
            }




        }
       
      

    }
}
