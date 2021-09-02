-- 1st task
select * from Satislar where PersonelID = 1

--2nd task
select * from Satislar where PersonelID in (1, 3)

--3rd task
select * from Satislar where PersonelID in (1, 3) and ShipVia = 1

--4th task
select *, (select MAX(SaDet.Ýndirim) from [Satis Detaylari] SaDet where Urunler.UrunID = SaDet.UrunID) as MaksimunIndirim from Urunler

--5th task
select *, (select MAX(SaDet.BirimFiyati) from [Satis Detaylari] SaDet where Satislar.SatisID = SaDet.SatisID) as MaksimunBirimFiyati from Satislar

--6th task
select *, (select SUM(SaDet.Miktar) from [Satis Detaylari] SaDet where Urunler.UrunID = SaDet.UrunID) as ToplamSatisMiktari from Urunler

--7th task
select top 1 ShipVia, (select SUM(SaDet.Miktar) from [Satis Detaylari] SaDet) as ToplamSatisMiktari from Satislar where ShipVia = 1