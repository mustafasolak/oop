# isimler tablosundaki tüm kayıtları getirelim
select * from isimler;

# isimler tablosundaki öğrencilerin sınıflarına ait tüm kayıtları getirelim
select sinifi from isimler;

# isimler tablosundaki tüm öğrencilerin ad ve soyadlarını getirelim
select adi, soyadi from isimler;

# isimler tablosuna yeni bir kayıt ekleyiniz.
insert into isimler(adi, soyadi, sinifi) values ("Semih", "KIZILBOĞA", "10/f");

# isimler tablosuna yeni bir kayıt ekleyiniz.
insert into isimler(adi, soyadi, sinifi) values ("Efe", "YILDIZ", "10/F");

# isimler tablosundan ismi Veli olan öğrencilerin kayıtlarını çekelim
select * from isimler where adi="Veli";

# isimler tablosundan sınıfı 9/e olan öğrencilerin kayıtlarını çekelim
select * from isimler where sinifi="9/e";

# isimler tablosundan 9/d sınıfında okuyan ve ismi veli olan öğrencilerin kayıtlarını çekelim
select * from isimler where sinifi="9/d" and adi="veli";

#isimler tablosundan id numarası 3 olan kaydı getirin
select * from isimler where id=3;

# isimler tablosundan 10/f sınıfında okuyan öğrencilerin isimlerini çekelim
select adi from isimler where sinifi="10/f";

# isimler tablosundaki ismi Veli olan veya soyismi HAVALI olan kayıtları çekelim
select * from isimler where soyadi="HAVALI" or adi="Veli"; 







#select adi, soyadi from isimler;
#select * from isimler;
#insert into isimler(adi, soyadi, sinifi) values ("Canan","HAVALI","9/e");
#select * from isimler;


#use ogrenci_bilgi;
#select * from isimler;
#select adi from isimler;
#select soyadi from isimler;

#insert into isimler(adi, soyadi, sinifi) values ("Hakan","YANDANBAKAR","9/f");
#insert into isimler(adi, soyadi, sinifi) values ("Veli","Yılmaz","9/d");
#insert into isimler(adi, soyadi, sinifi) values ("Hakan","YANDANBAKAR","9/f")
