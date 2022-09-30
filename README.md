# Artificial-Neuron


### Makine Öğrenmesi alanında kullanılan ve derin öğrenme alanının temelini de oluşturan Yapay Sinir Ağları (Artificial Neural Networks - ANN) konusundaki en temel yapılar Yapay Sinir Hücreleridir (Artificial Neuron). ANN’ler sınıflandırma, kümeleme ve tahminleme gibi birçok problemin çözümünde kullanılırlar.


* Yapay sinir hücresinin yapısı ve örnek bir hesaplama işlemi Şekil 3’te gösterilmektedir. Şekildeki Algılayıcı (Perceptron) modelinin veya nöronun 4 adet girdisi (x) ve 1 adet çıktısı (y) bulunmaktadır.

![neuron](https://user-images.githubusercontent.com/65908597/193350847-21434114-d24a-47fe-9bc9-3723d74b1ab9.png)

* Toplama İşlevi, girdilerle ağırlıkların çarpımları toplamının alınması şeklinde gerçekleştirilir:
![islem](https://user-images.githubusercontent.com/65908597/193352399-0ace8490-9642-466b-b184-cf2cd6d4202d.png)
* Gözetimli Öğrenmede (Supervised Learning), girdilerle beraber olması gereken çıktı değerleri (target) verilir / sistem tarafından sağlanır. Elimizde, toplamları pozitif olan iki adet sayıyı 1, negatif olanları ise -1 olarak sınıflandırmamızı gerektiren bir problemimiz olsun. Toplamları 0 olan sayıları hariç tutuyoruz. Ağın eğitiminde kullanılmak üzere Eğitim (training) verileri üretelim (Tablo 2):

![Adsız1](https://user-images.githubusercontent.com/65908597/193353024-7c1b504f-b749-4689-a6c5-eba390c00303.png)

#### Ağın eğitimi işleminde kullanılan Öğrenme Kuralının aşağıdaki gibi verildiğini varsayın:
* Ağın ürettiği çıktı (output), olması gereken değerden (beklenen) yani target değerinden farklı ise ağırlıkları λ*(t-o)*xi kadar arttır (t:target, o:output, λ:öğrenme katsayısı olmak üzere): Yani wi = wi + λ*(t-o)*xi .
* Output ve target değerleri aynı ise ağırlıklarda değişiklik yapma.

#### Eğitim: Tablo 1’deki tüm girdi değerlerini 10’a bölerek oluşan veri seti üzerinde gerçekleştirimidir. λ = 0.05 olarak alınmıştır. 10 epok ve 100 epok (epoch) sonunda yöntemin veri seti üzerindeki doğruluk (accuracy) değeri hesaplanıp yazılmıştır. Bir epok, tüm eğitim verilerinin sisteme bir kere sıra ile verilerek ağırlıkların değiştirilmesi işlemidir. Doğruluk değeri Doğru olarak sınıflandırılan örnek (veri) sayısı / toplam örnek sayısıdır. Elinizdeki 8 verinin 5 tanesi doğru olarak sınıflandırıldıysa doğruluk değeri acc = 5/8 = %62.5’tir.

* Test verilerinin kullanılmasındaki amaç; eğitim verilerinin neuronu eğitip eğitmediğini test etmek içindir.
