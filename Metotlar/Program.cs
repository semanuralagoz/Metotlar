using Metotlar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "amasya elması";


            string[] meyveler = new string[] { };

            Urun urun1 = new Urun(); //clas tanımlamak için bu yapılmalı clasın ornegi
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasy elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; //bu dizi urun1 ve urun2 arraylerini içinde tutar

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);


            }

            Console.WriteLine("--------------metotlar-------------");

            SepetManager sepetManager = new SepetManager();//clas çagırma(ornegini (instance)çagırma)
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



        }

    }
}

