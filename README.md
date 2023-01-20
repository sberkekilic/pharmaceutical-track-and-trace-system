# pharmaceutical-track-and-trace-system
Eczane İlaç Takip Sistemi C#
PROJE KODLAMA
-------------
ABSTRACT CLASS: İLAÇ
APPLICATION KATMANI: SİPARİŞ TAKİP
DATA KATMANI: MSSQL KULLANILARAK EN AZ 5 KOLON İSTENİYOR (1 TANESİ ID OLMAK ZORUNDA) DATAGRIDVIEW KULLANILACAK.
	      ID MARKAADI İLAÇKODU ALIŞTUTARI SATIŞMİKTARI STOK ALIŞTARİHİ SGKKARŞILAMA
ANA FORM: TOPLAMİLAÇSTOKADEDİ MARKATOPLAMİLAÇSTOKADEDİ MARKAORTALAMAİLAÇALIŞTUTARI MARKAORTALAMASATIŞMİKTARI

random değer ekleme satış miktarına
-------------------------------------
UPDATE Ilaclar
SET SatisMiktari = abs(checksum(NewId()) % AlisTutari)
WHERE SatisMiktari IS NULL

toplam ilaç stok adedi
------------------------
SELECT Sum(Ilaclar.Stok) AS ToplamIlacStok
FROM Ilaclar 

insert into ToplamStok(ToplamIlacStok)
select sum(Ilaclar.Stok)
from Ilaclar

update ToplamStok
set ToplamIlacStok =
(SELECT Sum(Ilaclar.Stok) AS ToplamIlacStok
FROM Ilaclar)

marka toplam ilaç stok adedi
----------------------
SELECT Ilaclar.MarkaAdi, Sum(Ilaclar.Stok) AS MarkaToplamIlacStok
FROM Ilaclar INNER JOIN AnaTablo ON Ilaclar.MarkaAdi = AnaTablo.Marka
GROUP BY Ilaclar.MarkaAdi;

update AnaTablo
set MarkaToplamIlacStok= t.sumStok
from AnaTablo a 
inner join 
(
select MarkaAdi,sum(Stok) sumStok
from Ilaclar
group by MarkaAdi
) t
on t.MarkaAdi = a.Marka

marka ortalama ilaç alış tutarı
-------------------------------
SELECT Ilaclar.MarkaAdi, Avg(Ilaclar.AlisTutari) AS MarkaOrtalamaIlacAlisTutari
FROM Ilaclar INNER JOIN AnaTablo ON Ilaclar.MarkaAdi = AnaTablo.Marka
GROUP BY Ilaclar.MarkaAdi;

update AnaTablo
set MarkaOrtalamaIlacAlisTutari= t.avgAlisTutari
from AnaTablo a 
inner join 
(
select MarkaAdi,avg(AlisTutari) avgAlisTutari
from Ilaclar
group by MarkaAdi
) t
on t.MarkaAdi = a.Marka

marka ortalama ilaç satış miktarı
---------------------------------
SELECT Ilaclar.MarkaAdi, Avg(Ilaclar.SatisMiktari) AS MarkaOrtalamaIlacSatisMiktari
FROM Ilaclar INNER JOIN AnaTablo ON Ilaclar.MarkaAdi = AnaTablo.Marka
GROUP BY Ilaclar.MarkaAdi;

update AnaTablo
set MarkaOrtalamaSatisMiktari= t.avgSatisMiktari
from AnaTablo a 
inner join 
(
select MarkaAdi,avg(SatisMiktari) avgSatisMiktari
from Ilaclar
group by MarkaAdi
) t
on t.MarkaAdi = a.Marka

İLAÇ MARKALARI
--------------
Johnson & Johnson (JJXXX)
Roche (RCXXX)
Sinopharm (SPXXX)
Pfizer (PFXXX)
Bayer (BYXXX)
Novartis (NVXXX)
Merck & Co. (MCXXX)
GlaxoSmithKline (GKXXX)
Sanofi (SNXXX)
AbbVie (AVXXX)
Abbott Laboratories (ALXXX)
Bristol-Myers Squibb (BMXXX)
Thermo Fisher Scientific (TFXXX)
AstraZeneca (AZXXX)
Amgen (AGXXX)
Pharmaceutical (PCXXX)
Gilead Sciences (GSXXX)
Eli Lilly & Co (ELXXX)
Novo Nordisk (NNXXX)

