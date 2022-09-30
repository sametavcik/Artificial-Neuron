# Artificial-Neuron


### Makine Öğrenmesi alanında kullanılan ve derin öğrenme alanının temelini de oluşturan Yapay Sinir Ağları (Artificial Neural Networks - ANN) konusundaki en temel yapılar Yapay Sinir Hücreleridir (Artificial Neuron). ANN’ler sınıflandırma, kümeleme ve tahminleme gibi birçok problemin çözümünde kullanılırlar.


* Yapay sinir hücresinin yapısı ve örnek bir hesaplama işlemi Şekil 3’te gösterilmektedir. Şekildeki Algılayıcı (Perceptron) modelinin veya nöronun 4 adet girdisi (x) ve 1 adet çıktısı (y) bulunmaktadır.

![neuron](https://user-images.githubusercontent.com/65908597/193350847-21434114-d24a-47fe-9bc9-3723d74b1ab9.png)

* Toplama İşlevi, girdilerle ağırlıkların çarpımları toplamının alınması şeklinde gerçekleştirilir:
![islem](https://user-images.githubusercontent.com/65908597/193352399-0ace8490-9642-466b-b184-cf2cd6d4202d.png)
* Gözetimli Öğrenmede (Supervised Learning), girdilerle beraber olması gereken çıktı değerleri (target) verilir / sistem tarafından sağlanır. Elimizde, toplamları pozitif olan iki adet sayıyı 1, negatif olanları ise -1 olarak sınıflandırmamızı gerektiren bir problemimiz olsun. Toplamları 0 olan sayıları hariç tutuyoruz. Ağın eğitiminde kullanılmak üzere Eğitim (training) verileri üretelim (Tablo 2):
