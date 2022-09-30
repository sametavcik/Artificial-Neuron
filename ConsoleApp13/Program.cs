using System;
using System.Collections;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)   // main oluşturulması
        {
            double[] girdi1 = { 6, 2, -3, -1, 1, -2, -4, -6 };  // veri setinin girilmesi
            double[] girdi2= { 5, 4, -5, -1, 1, 7, -2, -3 };  // veri setinin girilmesi




            double[] testVeriA1 = { 1, 2, 2, 1, 2, 1, 3, 3 };  //  test verisi
            double[] testVeriA2 = { 1, 2, 1, 2, 3, 2, 1, 2};


            ArrayList veriler = new ArrayList();   // test  verilerinin tutulduğu arraylist

            // verilerin 10 a bölünmesi

            onaBol(girdi1);     
            onaBol(girdi2);
            veriler.Add(onaBol(testVeriA1));
            veriler.Add(onaBol(testVeriA2));



            SinirHucresi hücre = new SinirHucresi(girdi1,girdi2);   // sinir hücresinin oluşturulması
            hücre.agirlikAta(hücre.r, hücre.agirliklar);   // sinir hücresinin ilk agırlıklarının atanması

            int[] targetler = hücre.targetHesapla(hücre.girdi1, hücre.girdi2);  //veri setinin targetlatının atanması
            int[] ciktilar = new int[girdi1.Length];  // outputların tutulduğu listenin oluşturulması
            
            Epok(targetler,ciktilar,hücre,100,veriler);  //epok u yapan fonksiyonun çağırılması
            
        }
        
        public static void Epok(int[] targetler,int[] ciktilar,SinirHucresi hücre,int epok,ArrayList veriler)  // epok yapan fonksiyon
        {
            int totalsayac = 0;
            for (int k = 0; k < epok; k++)  // kaç epok yapılacaksa o kadar dönen for döngüsü
            {
                int sayac1 = 0;
                for (int i = 0; i < targetler.Length; i++)  // veri setindeki eleman kadar dönen for döngüsü
                {
                    int sayac;
                    ciktilar[i] = hücre.toplamaIslemi(hücre.girdi1[i], hücre.girdi2[i], hücre.agirliklar);  // ilgili verilerin toplam fonksiyonuna sokulup output alınması ve listeye atılması
                    sayac = hücre.egitim(targetler[i], ciktilar[i], hücre.girdi1[i], hücre.girdi2[i], hücre.agirliklar);  // egitim fonksiyonunun çağırılması
                    if (sayac == 1)  
                    {
                        sayac1 += 1; // doğru değer sayacının bir arttırılması
                    }

                }
                totalsayac = sayac1;  // o epoktaki doğru sonuc sayısının total sayaca atılması
                if(k == 9) { // 10. epokta çalışan if bloğu
                Console.WriteLine((k + 1) + " " + "Epok sonunda *EĞİTİM* verilerinin  doğruluk oranı = % {0}", (double)sayac1/hücre.girdi1.Length*100);  // 10 epok sonunda eğitim verilerinin doğruluk değerinin yazdırılması
                for(int i = 0; i < veriler.Count/2; i++)  // test veri seti sayısı kadar çalışan for döngüsü
                    {
                        int sayi = hücre.testEgitim((double[])veriler[2*i], (double[])veriler[2*i+1], hücre.agirliklar);  // ilgili test verilerinin hücre sınıfının testeğitim metoduna gönderilmesi
                        double[] dizi = (double[])veriler[2 * i];  // dizi boyutunun bulunması için değişkene atılması
                        Console.WriteLine((k + 1) + " " + "Epok sonunda {0}. test veri setinin  doğruluk oranı = % {1}", i+1, (double)sayi / dizi.Length * 100);  // 10 epok sonunda test verilenin doğruluk değerinin yazdırılması
                    }

                }

        }
            Console.WriteLine(epok + " " + "Epok sonunda *EĞİTİM* verilerinin doğruluk oranı = % {0}", (double)totalsayac / hücre.girdi1.Length * 100);  // 100 epok sonunda doğruluk değerinin yazdırılması
            for (int i = 0; i < veriler.Count / 2; i++) // test veri seti sayısı kadar dönen for döngüsü
            {
                int x = hücre.testEgitim((double[])veriler[2 * i], (double[])veriler[2 * i + 1], hücre.agirliklar);  // ilgili test verilerinin hücre sınıfının testeğitim metoduna gönderilmesi
                double[] dizi = (double[])veriler[2 * i]; 
                Console.WriteLine(epok + " " + "Epok sonunda {0}.test veri setinin doğruluk oranı = % {1}", i+1,(double)x /dizi.Length * 100);  // 100 epok sonunda test verilerinin doğruluk değerinin yazdırılması
            }




        }

        public static double[] onaBol(double[] dizi1)  // içine gönderilen double tipinde dizinin elemanlarını 10 a bölen ve döndüren metot
        {
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = dizi1[i] / 10;

            }
            return dizi1;
        }

    }

}
