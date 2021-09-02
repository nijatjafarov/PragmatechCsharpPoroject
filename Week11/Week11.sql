select * from Musteriler
select * from Satislar order by PersonelID;
select * from Urunler;
select * from Kategoriler;
select * from [Satis Detaylari] order by UrunID;


--Task 1
select p.Adi, u.UrunID from Personeller p
cross join
Urunler u

except

select p.Adi, u.UrunID from Personeller p
join
Satislar s
on p.PersonelID = s.PersonelID
join
[Satis Detaylari] sd
on
s.SatisID = sd.SatisID
join
Urunler u
on u.UrunID = sd.UrunID
group by p.Adi, u.UrunID

--Task 2
select t.SirketAdi, u.UrunAdi from Tedarikciler t
cross join
Urunler u

except

select t.SirketAdi, u.UrunAdi from Tedarikciler t
join Urunler u
on u.TedarikciID = t.TedarikciID

--Task 3
select m.MusteriAdi, u.UrunAdi from Musteriler m
cross join
Urunler u

except 

select m.MusteriAdi, u.UrunAdi from Musteriler m
join
Satislar s
on m.MusteriID = s.MusteriID
join
[Satis Detaylari] sd
on
s.SatisID = sd.SatisID
join
Urunler u
on u.UrunID = sd.UrunID
group by m.MusteriAdi, u.UrunAdi

--Task 4
Create function dbo.EdvHesabla(@qiymet money) 
returns money 
as 
begin 
return @qiymet * 1.18
end 

select u.*,dbo.EdvHesabla(u.birimFiyati) as Edv from Urunler u

--Task 5
select sd.SatisID, s.MusteriID from [Satis Detaylari] sd
join
Satislar s
on s.SatisID = sd.SatisID and sd.BirimFiyati > 100

--Task 6
select u.*, t.SirketAdi from Urunler u
join
Tedarikciler t
on u.TedarikciID = t.TedarikciID

--Task 7
select s.*, m.MusteriAdi, p.SoyAdi, p.Adi from Satislar s
join
Musteriler m
on s.MusteriID = m.MusteriID
join
Personeller p
on s.PersonelID = p.PersonelID

--Task 8
select p.Adi, u.UrunID, sum(sd.BirimFiyati *sd.Miktar) from Personeller p
join
Satislar s
on p.PersonelID = s.PersonelID
join
[Satis Detaylari] sd
on
s.SatisID = sd.SatisID
join
Urunler u
on u.UrunID = sd.UrunID
group by p.Adi, u.UrunID

--Task 9
select p.Adi, u.KategoriID, count(u.KategoriID) as BuKategorideToplamSatislar from Personeller p
join
Satislar s
on p.PersonelID = s.PersonelID
join
[Satis Detaylari] sd
on
s.SatisID = sd.SatisID
join
Urunler u
on u.UrunID = sd.UrunID
group by p.Adi, u.KategoriID

--Task 10
select count(s.SatisID) as ToplamDasinanMal from Satislar s
join
[Satis Detaylari] sd
on sd.SatisID = s.SatisID and s.ShipVia = 1 and sd.BirimFiyati > 15

--Task 11
insert into Urunler values('UrunAdi', 14, 4, '10kg pkg', 25.40, 34, 10, 3, 0)

--Task 12
insert into Personeller values('Jafarov', 'Nijat', 'CEO', 'Mr.', 2001-09-12, 2021-08-20, 'Baku, Binagadi', 'Baku', NULL, 'AZ 1053', 'AZE', '(012) 444-3333', 2345, 'sekil uzundur deye yazmadim', 'Meslehetli mutexessisdir', NULL, 'http://accweb/emmployees/nijat.bmp');

--Task 13
insert into Bolge values(5, 'Uzu kuleye')

--Task 14
insert into Kategoriler values('KategoryName1', 'Kategory description1', 'Foto yazmiram, amma ozu atir')

--Task 15
begin
transaction
update Urunler set BirimFiyati = 15;
rollback transaction

--Task 16
update Urunler set BirimFiyati = 32 where UrunID = 10;

--Task 17
update Urunler set HedefStokDuzeyi += 5 where KategoriID = 5

--Task 18
insert into Urunler values('TestUrun', 12, 3, '14kg pkg', 20.40, 34, 10, 3, 0)
update Urunler set BirimFiyati = 10, HedefStokDuzeyi = 15 where UrunID = SCOPE_IDENTITY()
delete from urunler  where UrunID = SCOPE_IDENTITY()

--Task 19
select MusteriAdi from Musteriler
union
select SirketAdi from Tedarikciler

--Task 20
select tedarikciID, sum(birimFiyati*HedefStokDuzeyi) as toplamUrunFiyati from Urunler
group by TedarikciID

--Task 21
select MusteriID from Musteriler
except
select MusteriID from Satislar

--Task 22
select NakliyeciID from Nakliyeciler
except
select ShipVia from Satislar

--Task 23
Create procedure UrunListle @UrunAdi nvarchar(30), @qiymet money, @stok int
as
begin
insert into Urunler(UrunAdi, BirimFiyati, HedefStokDuzeyi) values (@UrunAdi, @qiymet, @stok)
select * from Urunler
end 

execute UrunListle @urunAdi = 'test', @qiymet = 5, @stok = 10

--Task 24
Create procedure UrunSil @UrunAdi nvarchar(30)
as
begin
delete from Urunler where UrunAdi = @UrunAdi
select * from Urunler
end

execute UrunSil @urunAdi = 'test'

--Task 25
create procedure StokArtir @urunID int
as
begin
update Urunler set HedefStokDuzeyi += 10 where UrunID = @urunID
select * from Urunler
end

execute StokArtir @urunID = 78

--Task 26
create view PersonellerVeMallar
as
select p.Adi, u.UrunID, sum(sd.BirimFiyati *sd.Miktar) as toplamUrunFiyati from Personeller p
join
Satislar s
on p.PersonelID = s.PersonelID
join
[Satis Detaylari] sd
on
s.SatisID = sd.SatisID
join
Urunler u
on u.UrunID = sd.UrunID
group by p.Adi, u.UrunID