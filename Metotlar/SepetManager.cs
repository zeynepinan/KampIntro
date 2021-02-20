using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax- yazım değişimleri
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Sepete eklendi : "+ urun);
        }

        public void Ekle2(string urunAdi,double fiyati,string aciklama)
        {
            Console.WriteLine("Sepete eklendi : " +urunAdi);
        }
    }
}
