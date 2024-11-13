# MayinTarlasi
# Mayın Tarlası Oyunu

Bu proje, C# programlama dili kullanılarak geliştirilmiş basit bir Mayın Tarlası oyunudur. Oyun, konsol tabanlıdır ve 20x20 boyutlarında bir oyun alanında rastgele yerleştirilmiş mayınlarla oynanır. Oyuncunun amacı, mayınlara basmadan tüm güvenli hücreleri açmaktır.

### Özellikler

	•	Oyun Alanı: 20x20 boyutlarında bir matris.
	•	Rastgele Mayın Yerleştirme: Oyun başladığında rastgele 40 adet mayın yerleştirilir.
	•	Mayın Sayısı Hesaplama: Her hücrede çevresindeki mayın sayısı otomatik olarak hesaplanır.
	•	Hücre Açma: Kullanıcı bir hücre seçtiğinde, hücreyi açar ve çevresindeki hücrelerin güvenli olup olmadığını gösterir.
	•	Oyun Kazanma ve Kaybetme Durumları: Oyuncu bir mayına basarsa oyunu kaybeder. Tüm güvenli hücreler açıldığında ise oyunu kazanır.

 ### Kullanım

Oyun başladığında konsolda 20x20 boyutunda bir oyun alanı görüntülenir. Kullanıcıdan sırasıyla satır ve sütun girişi yapması istenir.
	
       •        Bir hücreyi seçmek için satır ve sütun numaralarını girin.
       •	Eğer seçilen hücrede mayın varsa, oyun sona erer.
       •	Eğer seçilen hücrede mayın yoksa, hücre açılır ve çevresindeki mayın sayısı görüntülenir.
       •	Tüm güvenli hücreler açıldığında oyun kazanılır.
