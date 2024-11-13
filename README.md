# MayinTarlasi
# TR - Mayın Tarlası Oyunu

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

# EN - MineSweeper

This project is a simple Minesweeper game developed using the C# programming language. The game is console-based and played on a 20x20 grid with randomly placed mines. The player’s goal is to open all safe cells without hitting any mines.

### Features

	•	Game Board: A 20x20 grid.
	•	Random Mine Placement: 40 mines are randomly placed at the start of the game.
	•	Mine Count Calculation: Each cell displays the number of mines in its surrounding cells.
	•	Cell Reveal: When a cell is selected, it opens, revealing whether it is safe or surrounded by mines.
	•	Winning and Losing Conditions: The game is lost if the player hits a mine. If all safe cells are opened, the game is won.

### Usage

When the game starts, a 20x20 grid appears in the console. The player is prompted to enter row and column numbers.
	
        •	Enter row and column numbers to select a cell.
	•	If the chosen cell contains a mine, the game is over.
	•	If the cell is safe, it will display the number of surrounding mines.
	•	The game is won when all safe cells are opened.
