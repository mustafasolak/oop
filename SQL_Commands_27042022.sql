# isimler tablosundan sinifi 9/b olan ve 
# adi Hakan olan kayıtları silelim

delete from isimler 
	where 
		sinifi="9/b" and adi="Hakan";







# isimler tablosundan soyadi SOLAK olan 
# kayıtları silelim
delete from isimler where soyadi="SOLAK";









#isimler tablosundan 3 numaralı kaydı silelim
delete from isimler where id=3;

update isimler
  set 
    sinifi="9/c"
  where id=4;

# isimler tablosundaki id değeri 5 olan 
# kaydın adını Efe soyadını Can yapalım
update isimler
  set 
    adi="Efe", soyadi="Can", sinifi="9/a"
  where id=5;

    
    
    
    
    

# isimler tablosundaki id değeri 4 olan 
# kaydın adını Beren soyadını YILDIZ yapalım
update isimler
  set 
    adi="Beren", soyadi="YILDIZ"
  where
	id=4;








# isimler tablosundaki id değeri 3 olan 
# kaydın adını Abdullah soyadını Can yapalım
update isimler set
  adi="Abdullah",soyadi="Can"
    where
      id = 3;




# isimler tablosundaki soyismi SOLAK ve
# 9/d sınıfında okuyan öğrencilerin 
# isimleri Alper yapalım

update isimler set
  adi="Alper" 
      where soyadi="SOLAK" 
			and 
            sinifi="9/d";
  



# isimler tablosundaki 1 numaralı id ye 
# sahip olan kaydın adını Mustafa yapalım
update isimler
  set adi="Mustafa" where id=1;


update isimler 
 set adi="Hakan";


/*
select * from isimler;
select * from isimler 
where sinifi="9/d";



insert into isimler 
(adi,soyadi, sinifi) 
values ("Kamil", "Curcuna", "9/b");

insert into isimler 
(adi,soyadi, sinifi) 
values ("Ali", "SOLAK", "9/d");

insert into isimler 
(adi,soyadi, sinifi) 
values ("Ali", "SOLAK", "9/d");

select * from isimler;

# tabloya veri ekler
insert into isimler 
(adi,soyadi, sinifi) 
values ("Ali", "SOLAK", "9/d");
*/

/*
create table isimler(
	id int primary key auto_increment,
    adi text not null,
    soyadi text not null,
    sinifi text not null
);
*/
#use ogrenci_bilgi;
#create database ogrenci_bilgi;