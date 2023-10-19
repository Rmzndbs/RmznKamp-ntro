--select komutu datayı seç demek.  * ise tüm kolonlardan from ise Customersdan anlamında  
--çalıştırmak istediğin kodu seçtin belirttin execute dediğinde getiriyor.
--ANSII standardı olduğu için oracle de de , my sql de de çalışır.
Select * from Customers  --Customers ın bütün kolonlarını seç
--aslında bellekte bızım ıstedığimiz komtlara göre fake tablo oluşturup gösteryor.
Select CustomerID , ContactName,city from Customers --Customers daki CustomerID blogunu seç. tablo o	oluşturuyor.
select CustomerID Numarası , ContactName Adi ,city Sehir from Customers --alyas takmış olduk isimleri değiştirerek tablooluştur dedik.

Select * from Customers Where City = 'London' --tek tırnak sadece bunu execute etmek istiyorsan satırı seç öyle excetu et 
                                              -- şehiri london olan bütün Customersları seç getir. 

 sElEct * from  Products    --Case insensitivi dir yanı büyük küçük farketmez.

 select *from Products where categoryId=1 -- git bana 1 numaralı kategoriye ait ürünleri getir demiş oluypruz.

 select * from Products where categoryId=1 or categoryId=3 -- git bana 1 yada 3 numaralı kategoriye ait productları getir.
 
 -- >=(büyük eşittir)   <>10(ondan farklı olanları)

 select * from Products where CategoryID=1 and UnitPrice>=10 -- fiyatı 10 dan büyük eşit olanları ve kategori 1 olan ürünleri getir. 

  select * from Products order by ProductName  --order by sırala demek. bütün ürünleri seç ama ürün ismine göre sırala
  select * from Products order by CategoryID,ProductName -- her kategoride ürünleri ayrı ayrı listelerken ürün isimlerini kendi
 -- içinde  sıralıyor. yani kategori 1 in içindeki ürün isimlerini ayrı kategori 2 içindeki ürün isimleri ayrı ve alfabeye göre 

 select * from Products order by UnitPrice -- ürünleri fiyatına göre sırala.

 select * from Products order by UnitPrice asc -- asc = ascending demek  yani artan demek. ürünleri fiyatıan göre artarak sırala
 select * from Products order by UnitPrice desc -- desc= descending yani azalan demek.     Asending (Artan) Descenging(Düşen)

 select * from Products where CategoryID=1 order by UnitPrice desc-- caterıIdsı 1 olanları fıltrele onları fıyatına göre azalan oalrak sırala

 select count(*) from Products -- count say demek.tüm satırları say demek. Product tablosunda kaç data var. biz kataloggumuzda kaç tane ürün bulunduruyoruz.

 select count(*) from Products where CategoryID=2 -- kategoriıd si 2 olan kaç ürün var productta

 select count(*) Adet  from Products where CategoryID=2   -- adet i ben yazdım alyas olarak 

-- Yönetim dedi ki hangi kategoride kaç farklı ürünümüz var ?  yani kategori 1 de kaç tane kategori 2 de kaç tane ...
--tün kategorşlerş ayrı ayrı istiyor. ?? 

--select * from Products group by CategoryID --bu çalışmaz  bana datamı kategoryID ye göre grupla demek ama çalışmaz * olmaz.

select CategoryID from Products group by CategoryID  -- datalarımın içine bak bütün kategorileri tekrar etmeyecek şekilde bana listele demek.
select CategoryID,count(*) from Products group by CategoryID -- her bir group elemanı için ayrıca sayma işlemi hesaplanıyor.

select CategoryID,count(*) from Products group by CategoryID having count(*)<10 -- bana içerisinde 10 dan daha az olan ürün kategorileri ver.

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
--önce her zaman where çalışır.  önce verimi filtrele kategoriID ye göre grupla onlardan da sayısı 10 dan az olanları listele
--having kümülatiflere uygulanır.
--2 üsttekine göre sayının artmasının sebebi unitprice 20 den küçük dediğimizde sayılar azaldı doğal olarak 10 dan küçük olanların sayısı arttı.




--Inner JOIN--  ıdler düşün kateorıd tedarkçiıd ürün ıd biz tutarken numara olarak turuyoruz ama ekranda ismi lazım  sayıların bir anlamı yok müşteri numaraları bilmez
-- bu yüzden bunları birbirine bağlamalıyız. bunu join ile yapıyoruz.    JOIN birleştirmek demek. alt alta yazınca da çalışır
--Inner join sadece iki tabloda eşleşen dataları bir araya getirir eşleşmeyen data varsa onu getirmez.


select *   --yıldız dediğimiz için ürünle ilgili herşeyi getirdi.
from Products inner join Categories    --hem prodcuts hemde categories lerin bir araya getirilmiş şekli demek.
on Products.CategoryID=Categories.CategoryID  --ben bunları neye göre bir araya getireceğim kısmında on var. on şartı belirtiyor.
                                             --productstaki categoriıd ile categorilerdeki categoriıd eşitse onları yan yana getir demek.

--biraz özelleştirelim hepsi değil de bir bir yerden yapalım.

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName  -- products tablosundan productıd,name unit prime'ı ver categori tablosundan ise categorinin ismini ver. * tüm kolonlardı ben tüm kolonları istemiyorum sadece bu alanları istiyorum.
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID  

--Bu ilişkilendirmeye C#da DTO deniyor data transformation object   


--bu aşamadan sonra yukarıda öğrendiğin where, order by gruop by hepsini burada kullanabilirsin. 
select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID  
where Products.UnitPrice>10-- ürünlerden 10 dan büyük olanlar için onu categorilerle birleştir ve isimleriyle ve bana getir. 

--Inner join sadece iki tabloda eşleşen dataları bir araya getirir eşleşmeyen data varsa onu getirmez.

--order details boşluk bırakılarak yazılmış yazım kurallarına aykırı sql bunu 2 ayrı kodmuş gibi algılamasın diye []de yazılır.
--order sipariş demek 
--2 tabloyu join edeceğimiz zaman 2 tablodaki ortak kolonu bulmak gerek buda genelde ID
select *
from Products p inner join [Order Details] od      --products 'a p alyası order....'e od alyasını verdim.
on p.ProductID=od.ProductID --2155 tane çıktı
--inner join sadece eşleşen kayıtları getirir.  yönetim dedi ki hiç satış yapamadığımız ürünler nelerdir ?
--bana onu söyle o ürünlere kampanya yapalım. 

select *
from Products p left join [Order Details] od-- solda (products) olup  sağda (order details) olmayanları getir. yani ürünler tanlosunda var ama siparişlerde hiç yok.
on p.ProductID=od.ProductID  -- bunu sonucu da 2155 bu şu demek ben bütün ürün türlerinden satış yapmışım demek. çünkü ürünlerde olup sipariş detayında olmayan ürün yok.

select *
from Customers c inner join Orders o
on c.CustomerID=o.CustomerID   --830 tane sipariş varmış. yani eşleşeler.

select *
from Customers c left join Orders o
on c.CustomerID=o.CustomerID    --832 sonuç solda müşterilerde olup siparişlerde olmayanları da yansıt
                                --yani hem inner join olanları(yani eşleşenleri) hemde sol tarafta yani müşterilerde olup siparişte olmayanları da getir.(yani adam kayıt olmuş ama hiç sipariş vermemiş)


--Yönetim dedi ki bizim sistemimize kayıt olmuş ancak ürün almamış kişileri bana getir ben onlara kampanya yapayım.
--amaç onları aktif müşteri haline getirmek. örneğin sana özel indirim. sana özel ilk siparişine özel indirim.
--


select *
from Customers c left join Orders o-- solda olup sağda olmayanlar dolayısıyla sağda olmayanlar NULL olarak geçer.
on c.CustomerID=o.CustomerID 
where o.CustomerID is null --solda olan nulllar  -- hiç sipariş vermeyen iki kişiyi bulduk.bunlara yönetim indirim yapacak
                          -- bu koşul her zaman primary key e uygulanır. primary key null olmaz.


select *
from Orders o right join Customers c   --right join sağda olup solda olmayan demek tek fark bu. genelde left join kullanılır.
on c.CustomerID=o.CustomerID  



--ikiden fazla tabloyu join etmek istersem.
select *
from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o 
on o.OrderID=od.OrderID