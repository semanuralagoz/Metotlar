using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi:" + urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama, double fiyat,int StokAdedi)
        {
            Console.WriteLine("tebrikler  sepete eklendi:" + urunAdi);
        }
      

        
    }
}

