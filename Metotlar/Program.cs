using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması ";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //classları diziye atıyoruz
            Product[] urunler = new Product[] { urun1,urun2};

            //Product veri tipidir. Var da yazabiliriz bir sorun çıkmaz.
            //urunler dizisindeki elemanlar tek tek gezilir ve gezilirken her elemana urun takma ismi takılır.

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

            }

            Console.WriteLine("----------------Metotlar--------------");
            
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("", 5,"");
            sepetManager.Ekle2("", 5, "");
            sepetManager.Ekle2("", 5, "");
        }
    }
}
