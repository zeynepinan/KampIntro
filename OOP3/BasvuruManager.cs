using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) 
        {
            //Parametre olarak hangi kredi gönderilirse o kredi hesaplanır.
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
