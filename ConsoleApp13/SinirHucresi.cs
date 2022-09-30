using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class SinirHucresi
    {
        public double[] girdi1;  // veri setindeki x1 leri tutan listenin oluştuurlmaası
        public double[] girdi2;  // veri setindeki x2 leri tutan listenin oluşturulması
        public Random r = new Random();  // random değişkenin tutulması
        public double[] agirliklar = new double[2];  // agirlikları tutan listenin oluşturulması

        public SinirHucresi(double[] girdi1,double[] girdi2)  //  girdi değerlerini parametre olarak alan cons un oluşturulması
        {
            this.girdi1 = girdi1;  // girdilerin atanması
            this.girdi2 = girdi2;
            
        }

        public double[] agirlikAta(Random r,double[] agirliklar)  // agırlıkları rastgele atayan fonksiyon
        {
            for(int i = 0; i < agirliklar.Length; i++)  // agırlıkların sayısı kadar dönen for döngüsü
            {

                
                agirliklar[i] = (r.NextDouble()*2.0)-1.0;  // agırlıkların -1,1 aralığında rastgele atanması

            }
            return agirliklar;  // listenin geri döndüürlmesi
        }

        public int toplamaIslemi(double girdi1,double girdi2,double[] agirliklar)  // toplama fonksiyonu
        {
            int cikti;   // toplama sonucunda cıktı sonucunun tutulacağı değişkenin atanması
            double toplam;  // işlem sonucunun tutulduğu değişken

            
            toplam = 0;

            toplam = (girdi1 * agirliklar[0]) + (girdi2 * agirliklar[1]); // toplama işlemi 

            if(toplam >= 0.5)  // toplamın 0.5 tan büyüklük kontrolü
            {

             cikti = 1;  // sonucun atanması
             return cikti; // sonucun döndürülmesi

             }
             else
              {

               cikti = -1;
               return cikti;

              }

            
            
        }

        public int[] targetHesapla(double[] girdi1, double[] girdi2)   // targetları hesaplayan fonksiyon
        {
            int[] targetler = new int[girdi1.Length];  // target sayısı kadar elemanın olduğu listenin oluşturulması
            for(int i = 0; i < targetler.Length; i++)  // target sayısı kadar forun dönmesi
            {
                if(girdi1[i]+girdi2[i] > 0)  // verilerin toplamı 0 dan büyükse 1 değilse -1 targetinin listeye atılması
                {
                    targetler[i] = 1;
                }
                else
                {
                    targetler[i] = -1;
                }
            }
            return targetler;  // listenin döndürülmesi
        }

        public int egitim(int target,int cikti,double girdi1,double girdi2, double[] agirliklar)   // egitim fonksiyonu
        {
            int sayac = 0;  // egitim sonucunun tutulduğu değişken

            double deger1 = agirliklar[0];  // ilk ağırlığın atanması
            double deger2 = agirliklar[1];  // ikinci ağırlığın atanması

            if (cikti == -1 && target == 1)  // cıktı -1 se ve target 1 se ağırlıkları arttıran blok
             {

               deger1 += 0.05 * 2 * girdi1; 
               deger2 += 0.05 * 2 * girdi2;

             }else if(cikti == 1 && target == -1)  // cıktı 1 ve target -1 se agırlıkları azaltan blok
              {
                deger1 += 0.05 * -2 * girdi1;
                deger2 += 0.05 * -2 * girdi2;
              }
              else
               {
                 sayac += 1;  // target outputa eşitse sayacın 1 atanması
               }

            agirliklar[0] = deger1;  // yeni ağırlıkların atanması
            agirliklar[1] = deger2;

            return sayac; // o veri seti için doğruluk sonucunun geri döndürülmesi
        }
        public int testEgitim(double[] testVeri1,double[] testVeri2,double[] agirliklar)  // içine gönderilen double[] tipindeki dizi verilerinin o epok sonundaki ağırlıklarla çarpılarak target değerlerine eşit mi değilmi kontrol eden metot
        {
            int sayac = 0;  // test verisindeki doğru verilerin sayısının tutulacağı değişken
            int[] ciktilar = new int[testVeri1.Length];  // test verilerinin outputlarının tutulacağı dizi
            int[] targetler = targetHesapla(testVeri1, testVeri2);  // test verilerinin targetlarının hesaplanması
            for (int a = 0; a < testVeri1.Length; a++)  // veri sayısı kadar dönen for döngüsü
            {

                ciktilar[a] = toplamaIslemi(testVeri1[a], testVeri2[a], agirliklar);  // çıktıların oluşturulması

                if(ciktilar[a] == targetler[a])  // target == output kontrolü
                {
                    sayac += 1;  // sayacın 1 arttırılması
                }

            }

            return sayac;  // sayacın gerş döndürülmesi

        }


    }
}
