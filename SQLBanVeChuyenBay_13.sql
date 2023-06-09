CREATE DATABASE QUANLYBANVECHUYENBAY
GO

USE QUANLYBANVECHUYENBAY
GO

DROP DATABASE QUANLYBANVECHUYENBAY
GO

SET DATEFORMAT DMY

CREATE TABLE HANHKHACH (
	MaHK int IDENTITY (1,1),
	CMND varchar(12),
	Hoten varchar (40),
	Dienthoai varchar (20),
	Ngsinh smalldatetime,
	Email varchar (40),
	CONSTRAINT PK_KH PRIMARY KEY (MaHK)
)


CREATE TABLE SANBAY (
	MaSBay varchar(3),
	Tensb varchar (40),
	CONSTRAINT PK_SB PRIMARY KEY (MaSBay)
)

CREATE TABLE CHUYENBAY (
	MaCBay varchar (6),
	MaSanBayDi varchar(3),
	MaSanBayDen varchar(3),
	KhoiHanh date,
	GioKhoiHanh time,
	TgianBay int,
	Dongia money
	CONSTRAINT PK_CB PRIMARY KEY (MaCBay)
)
alter table chuyenbay add TgianBay int


CREATE TABLE THONGTINSANBAYTRUNGGIAN (
	MaCBay varchar(6),
	MaSBayTrungGian varchar(3),
	ThoiGianDung int,
	Ghihu text,
	CONSTRAINT PK_CTCB PRIMARY KEY (MaCBay, MaSBayTrungGian)
)

CREATE TABLE VECHUYENBAY (
	Mave varchar(6),
	MaHK int,
	MaCBay varchar (6),
	Hangve int,
	--Maghe varchar(8),
	NgayBanVe smalldatetime,
	GiaVe money,
	Tinhtrangve varchar(20)
	CONSTRAINT PK_VCB PRIMARY KEY (Mave)
)--------
alter table vechuyenbay add Tinhtrangve varchar(20)

CREATE TABLE VITRIGHE (
	MaCBay varchar(6),
	Hangghe int,
	Tinhtrang varchar(10) default ('Con cho'),
	CONSTRAINT PK_VTG PRIMARY KEY (MaCBay, Hangghe)
)


CREATE TABLE BANGHOADON (
	MaHoaDon varchar (5),
	MaHK int,
	MaCBay varchar(6),
	ThanhTien money,
	NgayThanhLap smalldatetime default getdate(),
	CONSTRAINT PK_BDG PRIMARY KEY (MaHoaDon)
)

CREATE TABLE BAOCAOTHANG (
	MaBaoCaoThang varchar(7),
	Thang int,
	Nam int,
	CONSTRAINT PK_BCT PRIMARY KEY (MaBaoCaoThang)
)

CREATE TABLE CHITIETBAOCAOTHANG (
	MaCBay varchar(6),
	Mabaocaothang varchar(7),
	Sove int DEFAULT ('0'),
	Dthuthang money DEFAULT ('0'),
	--MaCTBC varchar(4) default ('CTBC'),
	CONSTRAINT PK_CTBCT PRIMARY KEY (Mabaocaothang, MaCBay)
)

/*CREATE TABLE BAOCAONAM (
	Nam int,
	SoCBay int DEFAULT ('0'),
	Dthunam money DEFAULT ('0'),	
	CONSTRAINT PK_BCN PRIMARY KEY (Nam)
)*/

CREATE TABLE THAMSO (
	Thoigianbaytt int,
	SLSbayTGtoida int,
	Tgiandungtoithieu int,
	Tgiandungtoida int,
	Thoihandatve int,
	Thoihanhuyve int
)


CREATE TABLE HANGVE (
	MaHangve int,
	TenHangVe varchar(40),
	TiLe float
	CONSTRAINT PK_HV PRIMARY KEY (MaHangVe)
)


CREATE TABLE SOLUONGHANGVE (
	ID int IDENTITY (1001,1),
	MaHangVe int,
	MaCBay varchar(6),
	SoLuongGhe int,
	SoGheDat int default '0',
	CONSTRAINT PK_SLHV PRIMARY KEY (ID)
)


-- Khoa ngoai
ALTER TABLE CHUYENBAY ADD CONSTRAINT FK_CB1 FOREIGN KEY (MaSanBayDi) REFERENCES SANBAY(MASBay)
ALTER TABLE CHUYENBAY ADD CONSTRAINT FK_CB2 FOREIGN KEY (MaSanBayDen) REFERENCES SANBAY(MASBay)


ALTER TABLE VECHUYENBAY ADD CONSTRAINT FK_VCB1 FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY (MaCBay)
ALTER TABLE VECHUYENBAY ADD CONSTRAINT FK_VCB2 FOREIGN KEY (MaHK) REFERENCES HANHKHACH (MAHK)
ALTER TABLE VECHUYENBAY ADD CONSTRAINT FK_VCB3 FOREIGN KEY (MaCBay, HangVe) REFERENCES VITRIGHE (MaCBay, Hangghe)	
ALTER TABLE VECHUYENBAY ADD CONSTRAINT FK_VCB4 FOREIGN KEY (HangVe) REFERENCES HANGVE (MaHangVe)

ALTER TABLE VITRIGHE ADD CONSTRAINT FK_VTG FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY (MaCBay)

ALTER TABLE THONGTINSANBAYTRUNGGIAN ADD CONSTRAINT FK_SBTG1 FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY(MaCBay)
ALTER TABLE THONGTINSANBAYTRUNGGIAN ADD CONSTRAINT FK_SBTG2 FOREIGN KEY (MaSBayTrungGian) REFERENCES SANBAY(MaSBay)

ALTER TABLE BANGHOADON ADD CONSTRAINT FK_BHD1 FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY (MaCBay)

ALTER TABLE CHITIETBAOCAOTHANG ADD CONSTRAINT FK_CT1 FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY (MaCBay)
ALTER TABLE CHITIETBAOCAOTHANG ADD CONSTRAINT FK_CT2 FOREIGN KEY (Mabaocaothang) REFERENCES BAOCAOTHANG (MaBaoCaoThang)

ALTER TABLE SOLUONGHANGVE ADD CONSTRAINT FK_SLHV1 FOREIGN KEY (MaCBay) REFERENCES CHUYENBAY(MaCBay)
ALTER TABLE SOLUONGHANGVE ADD CONSTRAINT FK_SLHV2 FOREIGN KEY (MaHangVe) REFERENCES HangVe(MaHangVe)


--check
alter table chuyenbay add constraint ck_sbay check (MaSanBayDi != MaSanBayDen)
ALTER TABLE VITRIGHE ADD CONSTRAINT CK_VITRIGHE CHECK (Tinhtrang in ('Da het', 'Con cho'))
alter table soluonghangve add constraint ck_soluong check (SoLuongGhe-SoGheDat >=0 )
alter table vechuyenbay add constraint ck_tinhtrangve check (Tinhtrangve in ('Da thanh toan', 'Chua thanh toan'))
alter table vechuyenbay add constraint 

SET DATEFORMAT DMY
--du lieu hanh khach
INSERT INTO HANHKHACH VALUES ('058202005245', 'DAO VO TRUONG GIANG', '0844573705', '15/11/2002', 'camgiangson15@gmail.com')
INSERT INTO HANHKHACH VALUES ('058202005246', 'DAO VO TRUONG SON', '0879038473', '20/12/2007', 'hacker15@gmail.com')
INSERT INTO HANHKHACH VALUES ( '058202005247', 'TRAN HOANG THUAN', '0844573706', '15/12/2002', 'thuantran12@gmail.com')
INSERT INTO HANHKHACH VALUES ('264554695', 'GIANG KA', '0844573709', '15/11/2002','20521258@gm.uit.edu.vn')
INSERT INTO HANHKHACH VALUES ('058202005248', 'CHO HAU', '0844573777', '20/09/2005','chohau20@gmail.com')
INSERT INTO HANHKHACH VALUES ('136524000999', 'DUONG TANG', '19001081', '15/11/2002','duongtang@gmail.com')
INSERT INTO HANHKHACH VALUES ('136524000998', 'NGO KHONG', '19001082', '02/06/2002','ngokhong@gmail.com')
INSERT INTO HANHKHACH VALUES ('136524000997', 'Bat gioi', '19001083', '02/04/2002','batgioi@gmail.com')
INSERT INTO HANHKHACH VALUES ('136524000996', 'Sa tang', '19001082', '02/02/2002','Satang@gmail.com')
INSERT INTO HANHKHACH VALUES ('136524000995', 'BachLong', '19001086', '02/01/2002','BachLong@gmail.com')
SELECT *FROM HANHKHACH
--------------------------
--du lieu san bay
INSERT INTO SANBAY VALUES ('VCS', 'San bay Con Dao')
INSERT INTO SANBAY VALUES ('VCA', 'San bay quoc te Can Tho')
INSERT INTO SANBAY VALUES ('DAD', 'San bay quoc te Da Nang')
INSERT INTO SANBAY VALUES ('HPH', 'San bay quoc te Cat Bi')
INSERT INTO SANBAY VALUES ('HAN', 'San bay quoc te Noi Bai')
INSERT INTO SANBAY VALUES ('SGN', 'San bay quoc te Tan Son Nhat')
INSERT INTO SANBAY VALUES ('CXR', 'San bay quoc te Cam Ranh')
INSERT INTO SANBAY VALUES ('ALB', 'San bay quoc te Albany')
INSERT INTO SANBAY VALUES ('PEK', 'San bay quoc te thu do Bac Kinh')
INSERT INTO SANBAY VALUES ('CDG', 'San bay Paris')
select*from sanbay

--du lieu chuyen bay
insert into chuyenbay values ('VJ0001', 'VCS', 'VCA', '1/6/2022', '1:00:00','1000000', '300')
insert into chuyenbay values ('VJ0002', 'VCS', 'VCA', '1/6/2022', '1:00:00', '1500000', '500')
insert into chuyenbay values ('VJ0003', 'HAN', 'SGN', '1/7/2022', '1:00:00', '1700000', '1000')
insert into CHUYENBAY
select*from chuyenbay
delete CHUYENBAY where MaCBay = 'VJ0008'
delete chuyenbay where MaCBAY in ('VJ0009', 'VJ0008', 'VJ0007', 'VJ0006', 'VJ0005')
---du lieu thong tin san bay trung gian
insert into THONGTINSANBAYTRUNGGIAN values ('VJ0003','DAD', '00:15:00', '')

select *from THONGTINSANBAYTRUNGGIAN
delete THONGTINSANBAYTRUNGGIAN where MaCBay in ('VJ0005', 'VJ0006', 'VJ0007', 'VJ0008')
---du lieu Hang ve
insert into HANGVE values ('1','Hang thuong gia', '1.05')
insert into HANGVE values ('2','Hang pho thong', '1')
insert into HANGVE values ('3','Hang SkyBoss', '2')

select *from hangve
---du lieu so luong hang ve
insert into SOLUONGHANGVE values ('1', 'VJ0001', '30', '')
insert into SOLUONGHANGVE values ('2', 'VJ0001', '25', '')
insert into SOLUONGHANGVE values ('1', 'VJ0002', '40', '')
insert into SOLUONGHANGVE values ('2', 'VJ0002', '30', '')
insert into SOLUONGHANGVE values ('3', 'VJ0002', '30', '')
insert into SOLUONGHANGVE values ('1', 'VJ0003', '50', '')
insert into SOLUONGHANGVE values ('2', 'VJ0003', '100', '')
insert into SOLUONGHANGVE values ('3', 'VJ0003', '30', '')

select *from SOLUONGHANGVE
delete SOLUONGHANGVE where MaCBAY in ('VJ0008', 'VJ0007', 'VJ0006', 'VJ0005')
---du lieu  vitrighe
insert into VITRIGHE VALUES ('VJ0001', '1' ,'Con cho')
insert into VITRIGHE values ('VJ0001', '2', 'Con cho')
insert into VITRIGHE VALUES ('VJ0002', '1' ,'Con cho')
insert into VITRIGHE values ('VJ0002', '2', 'Con cho')
insert into VITRIGHE values ('VJ0002', '3', 'Con cho')
insert into VITRIGHE VALUES ('VJ0003', '1' ,'Con cho')
insert into VITRIGHE values ('VJ0003', '2', 'Con cho')
insert into VITRIGHE values ('VJ0003', '3', 'Con cho')
select *from vitrighe

----du lieu bang don gia
insert into BANGHOADON values ('HDVJ1', 'VJ0001', '1000000')
set dateformat dmy
----du lieu ve chuyen bay
insert into vechuyenbay values ('', '1', 'VJ0001', '1', '13/5/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '2', 'VJ0001', '2', '14/5/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '3', 'VJ0002', '1', '14/5/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '4', 'VJ0002', '3', '14/5/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '5', 'VJ0002', '2', '14/05/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '6', 'VJ0003', '1', '14/05/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '7', 'VJ0003', '2', '14/05/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '8', 'VJ0003', '3', '14/05/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '9', 'VJ0003', '3', '14/05/2022',null, 'Da thanh toan')
insert into vechuyenbay values ('', '10', 'VJ0003', '3', '14/05/2022',null, 'Chua thanh toan')
insert into vechuyenbay values ('', '8', 'VJ0002', '2', '16/05/2022','', 'Da thanh toan')

delete from VECHUYENBAY where mave='TVJ001'
insert into vechuyenbay values ('', '', '', '')
delete from VECHUYENBAY where MaHK='3' and MaCBay='VJ0002' 
delete from VECHUYENBAY
select *from vechuyenbay
select *from CHITIETBAOCAOTHANG
select *from SOLUONGHANGVE

----du lieu BaoCaoThang
insert into BAOCAOTHANG values('B012022', '1', '2022')
insert into BAOCAOTHANG values('B022022', '2', '2022')
insert into BAOCAOTHANG values('B032022', '3', '2022')
insert into BAOCAOTHANG values('B042022', '4', '2022')
insert into BAOCAOTHANG values('B052022', '5', '2022')
insert into BAOCAOTHANG values('B062022', '6', '2022')
insert into BAOCAOTHANG values('B072022', '7', '2022')
insert into BAOCAOTHANG values('B082022', '8', '2022')
insert into BAOCAOTHANG values('B092022', '9', '2022')
insert into BAOCAOTHANG values('B102022', '10', '2022')
insert into BAOCAOTHANG values('B112022', '11', '2022')
insert into BAOCAOTHANG values('BC12022', '12', '2022')
select*from BAOCAOTHANG
---du lieu chitietbaocaothang
insert into CHITIETBAOCAOTHANG values ('VJ0001', 'B062022', '', '')
insert into CHITIETBAOCAOTHANG values ('VJ0002', 'B062022', '', '')
insert into CHITIETBAOCAOTHANG values ('VJ0003', 'B072022', '', '')
select *from CHITIETBAOCAOTHANG
delete from CHITIETBAOCAOTHANG
--- du lieu bao cao nam
SELECT*FROM SOLUONGHANGVE

---du lieu tham so
Insert into THAMSO values ('30', '2', '10', '20', '1', '1')
select *from thamso


-----------------------------------------------CODE CÁC CHỨC NĂNG ----------------------------------------------

----------Nhan lich chuyen bay
Insert into CHUYENBAY values ('"MACBAY"', '"MASANBAYDI"', '"MASANBAYDEN"', '"NGAYGIO"', '"THOIGIANBAY"', '"DonGia"')
Insert into SOLUONGHANGVE VALUES ('"MaHangVe"', '"MaCBay"', '"SoLuongGhe"', '0')
Insert into THONGTINSANBAYTRUNGGIAN VALUES ('"MaCBay"', '"MaSBayTrungGian"', '"ThoiGianDung"', '"GhiChu"')
select *from CHUYENBAY

----------DATCHO, Datve
Insert into HANHKHACH VALUES ('"CMND"', '"HOTEN"', '"DIENTHOAI"', '"NGSINH"', '"EMAIL"')
--Dat ve
Insert into VECHUYENBAY values ('"MAHK"', '"MaCBay"', '"HangVe"', '"NgayBanVe"', null, '"Chua thanh toan"')
--Thanh toan
Insert into VECHUYENBAY values ('"MAHK"', '"MaCBay"', '"HangVe"', '"NgayBanVe"', null, '"Da Thanh toan"')
--Xem thong tin dat ve
Select VECHUYENBAY.MaHK, Hoten, Email, Dienthoai, Mave, Hangve, NgayBanVe, GiaVe, Tinhtrangve    --cần thông tin gì thì bổ sung
from VECHUYENBAY inner join CHUYENBAY on VECHUYENBAY.MaCBay=CHUYENBAY.MaCBay
				inner join HANHKHACH on VECHUYENBAY.MaHK=HANHKHACH.MaHK
where VECHUYENBAY.MaCBay='VJ0001'


---------bao cao doanh thu thang
Select MaCBay, Sove, Dthuthang, 
		(Dthuthang/(select Sum(Dthuthang) from BAOCAOTHANG left join CHITIETBAOCAOTHANG on BAOCAOTHANG.MaBaoCaoThang = CHITIETBAOCAOTHANG.Mabaocaothang
											where Thang= '6' and Nam='2022')) * 100 'Ty le'
from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang
where Thang='6' and Nam = '2022'
Group by MaCBay, Sove, Dthuthang, Thang, Nam


Select Sum(Dthuthang) 'Tong doanh thu thang'
from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang 
where Thang='6' and Nam = '2022'


--------- bao cao nam
Select Thang, Count(MaCBay) 'So chuyen bay', Sum(Dthuthang) 'Doanh thu', (Sum(Dthuthang)/(select Sum(Dthuthang) from CHITIETBAOCAOTHANG))*100 'Ti le' from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang where Nam = '2022' group by  Thang

Select Sum(Dthuthang) 'Tong doanh thu nam' from BAOCAOTHANG bct left join CHITIETBAOCAOTHANG ct on bct.MaBaoCaoThang = ct.Mabaocaothang where Nam = '2022'


-----Danh sach san bay
Select *from SANBAY
order by MaSBay
--them, xoa, sua
Insert into SANBAY values ('', '')
Delete from SANBAY where MaSBay='' or Tensb=''
Update SANBAY SET Tensb='' where MaSBay=''


----- Danh sach hang ve
select *from HANGVE
order by MaHangVe
--them, xoa, sua
Insert into Hangve values ('', '', '', '', '')
Delete from Hangve where MaHangVe=''
Update HANGVE set TenHangVe='' where MaHangVe=''
Update HANGVE set TiLe='' where MaHangVe=''

------ Thay đổi quy định
Update Thamso set Thoigianbaytt=''
Update Thamso set SLSbayTGtoida=''
Update THAMSO set Tgiandungtoithieu=''
Update THAMSO set Thoihandatve=''
Update THAMSO set Tgiandungtoida=''
Update THAMSO set Thoihandatve=''
Update THAMSO set Thoihanhuyve=''

update CHUYENBAY set Dongia = '10000000' where MaCBay = 'VJ0001'
------ Tra cứu chuyến bay

select MaSanBayDi, MaSanBayDen, KhoiHanh, TgianBay, 
		Sum(SoLuongGhe)-Sum(SoGheDat) 'SoGheTrong', Sum(SoGheDat) 'So ghe dat'
from Chuyenbay cb left join SoluongHangve slhv on cb.MaCBay=slhv.MaCBay 
where cb.MaCBay in (SELECT MaCBay
				from CHUYENBAY
				where MaSanBayDi='VCS' and MaSanBayDen='VCA' and khoihanh= '1/6/2022 09:00:00'and TgianBay='01:00:00')
Group By MaSanBayDi, MaSanBayDen, Khoihanh, TgianBay



----------------------- CÁC TRIGGER ------------------

CREATE TRIGGER trg_CapNhatXoaVe on VECHUYENBAY  after delete as
begin
	update SOLUONGHANGVE
	set SoGheDat= SoGheDat - 1 
	from SOLUONGHANGVE
	join deleted on SOLUONGHANGVE.MaCBay=deleted.MaCBay and SOLUONGHANGVE.MaHangVe=deleted.Hangve
	/*update CHITIETBAOCAOTHANG
	set Tyle = Dthuthang/(Select Sum(Dthuthang) from CHITIETBAOCAOTHANG)
	from CHITIETBAOCAOTHANG ct inner join deleted del on ct.MaCBay=del.MaCBay
	where Sove != 0 and del.Tinhtrangve = 'Da thanh toan'

	update CHITIETBAOCAOTHANG
	set Tyle = 0
	where Sove = 0*/
END
create trigger trg_tinhdthuxoave on VECHUYENBAY after delete as
begin
		update CHITIETBAOCAOTHANG
		set Dthuthang = Dthuthang - del.GiaVe
		from deleted del
		where del.Tinhtrangve = 'Da thanh toan' and CHITIETBAOCAOTHANG.MaCBay=del.MaCBay
end

create trigger trg_XOASOVECT on VECHUYENBAY after delete as
begin
	update CHITIETBAOCAOTHANG
	Set Sove = Sove - 1
	from deleted del, CHITIETBAOCAOTHANG ct
	where del.MaCBay = ct.MaCBay
end

CREATE TRIGGER trg_Themve on VECHUYENBAY  after insert as
begin
	update SOLUONGHANGVE
	set SoGheDat = SoGheDat + 1
	from SOLUONGHANGVE
	join inserted on SOLUONGHANGVE.MaCBay=inserted.MaCBay and SOLUONGHANGVE.MaHangVe=inserted.Hangve

	/*update CHITIETBAOCAOTHANG
	set Tyle = Dthuthang/(Select Sum(Dthuthang) from CHITIETBAOCAOTHANG)
	from inserted ins left join CHITIETBAOCAOTHANG ct on ins.MaCBay=ct.MaCBay
	where ins.Tinhtrangve = 'Da thanh toan'*/


END
select * from SANBAY
select *from CHITIETBAOCAOTHANG
select*from THONGTINSANBAYTRUNGGIAN
alter table THONGTINSANBAYTRUNGGIAN add GhiChu text
CREATE TRIGGER trg_setgiave on VECHUYENBAY  after insert as
begin
	update VECHUYENBAY
	SET Giave= Dongia * TiLe
	FROM (inserted ins JOIN CHUYENBAY on ins.MaCBay=CHUYENBAY.MaCBay
						JOIN HANGVE ON ins.Hangve = HANGVE.MaHangve)
	where VECHUYENBAY.MaHK=ins.MaHK and VECHUYENBAY.MaCBay = ins.MaCBay

end

CREATE TRIGGER trg_setdthuins on VECHUYENBAY  after insert as
begin
	update CHITIETBAOCAOTHANG
	set Dthuthang = Dthuthang + vb.GiaVe
	from VECHUYENBAY vb	join inserted ins on (vb.MaCBay=ins.MaCBay and vb.MaHK=ins.MaHK)
	where ins.Tinhtrangve = 'Da thanh toan' and CHITIETBAOCAOTHANG.MaCBay=ins.MaCBay

	
end

CREATE TRIGGER trg_setsoveins on VECHUYENBAY  after insert as
begin
	update CHITIETBAOCAOTHANG
	Set Sove = Sove + 1
	from inserted ins, CHITIETBAOCAOTHANG ct
	where ins.MaCBay = ct.MaCBay
end



create trigger ins_chitietbct on CHUYENBAY 
after insert as
DECLARE @maCBay VARCHAR(6), @khoiHanh smalldatetime
select MaCBay, KhoiHanh from inserted;
insert into CHITIETBAOCAOTHANG values(@maCBay,@




create trigger rnd_Mave on VECHUYENBAY
after insert
as
begin
	UPDATE VECHUYENBAY
	SET Mave = (
		SELECT c1 AS [	text()]
		FROM
		(
			SELECT TOP (6) c1
			FROM
			(
				VALUES
					('A'), ('B'), ('C'), ('D'), ('E'), ('F'), ('G'), ('H'), ('I'), ('J'),
					('K'), ('L'), ('M'), ('N'), ('O'), ('P'), ('Q'), ('R'), ('S'), ('T'),
					('U'), ('V'), ('W'), ('X'), ('Y'), ('Z'), ('0'), ('1'), ('2'), ('3'),
					('4'), ('5'), ('6'), ('7'), ('8'), ('9')	
			) AS T1(c1) 
		ORDER BY ABS( CHECKSUM( NEWID() ) )
		) AS T2
		FOR XML PATH('')
	)
	WHERE Mave in ( select Mave from inserted )
end


create trigger trg_xoadulieuchuyenbay on CHUYENBAY 
before delete as
begin
	delete CHITIETBAOCAOTHANG
	from CHITIETBAOCAOTHANG ct, deleted dlt
	where ct.MaCBay=dlt.MaCBay

	delete SOLUONGHANGVE
	from SOLUONGHANGVE sl, deleted dlt
	where sl.MaCBay=dlt.MaCBay

	delete THONGTINSANBAYTRUNGGIAN
	from THONGTINSANBAYTRUNGGIAN tt, deleted dlt
	where tt.MaCBay=dlt.MaCBay

	delete VECHUYENBAY
	from VECHUYENBAY vb, deleted dlt
	where vb.MaCBay=dlt.MaCBay

	delete VITRIGHE
	from VITRIGHE vt, deleted dlt
	where vt.MaCBay=dlt.MaCBay
end

---test


select cb.MaCBay, cb.KhoiHanh, cb.TgianBay, 
		(Select (Sum(SoLuongGhe)-SUM(SoGheDat)) from SOLUONGHANGVE sl where sl.MaCBay=cb.MaCBay) 'So ghe trong',
		sb2.Tensb 'Ten San Bay Di', sb1.Tensb 'Ten San Bay Den', sb.Tensb 'Ten San Bay Trung Gian', cb.Dongia
from CHUYENBAY cb left join THONGTINSANBAYTRUNGGIAN tt on cb.MaCBay=tt.MaCBay
				--left join SOLUONGHANGVE sl on cb.MaCBay=sl.MaCBay
				left join SANBAY sb2 on cb.MaSanBayDi=sb2.MaSBay
				left join SANBAY sb1 on cb.MaSanBayDen=sb1.MaSBay
				left join SANBAY sb on tt.MaSBayTrungGian=sb.MaSBay

select cb.MaCBay 'Ma Chuyen Bay', cb.KhoiHanh 'Ngay Khoi Hanh', cb.GioKhoiHanh 'Gio Khoi Hanh', cb.TgianBay
                'Thoi gian bay', sb2.Tensb 'San bay di', sb1.Tensb 'San bay den', cb.Dongia 'Don gia'
                from CHUYENBAY cb left join SANBAY sb2 on cb.MaSanBayDi = sb2.MaSBay
                left join SANBAY sb1 on cb.MaSanBayDen = sb1.MaSBay
               
--where sb2.Tensb like '_Noi Bai' and sb1.Tensb like '_Tan Son Nhat'	 and KhoiHanh = '7/1/2022 9:00:00'
where sb2.Tensb='San bay quoc te Noi Bai' and sb1.Tensb='San bay quoc te Tan Son Nhat'	 and convert()	
	set dateformat dmy						
	select*from chuyenbay
--------------------------------------------------------CHUC NANG PHAN QUYEN ----------------------------------------
CREATE TABLE NHANSU (
	TenTK varchar(40),
	Matkhau varchar(40),
	Hoten varchar(40),
	Gioitinh varchar(3),
	Ngsinh smalldatetime,
	email varchar(40),
	Sodienthoai varchar(20),
	Chucvu varchar(10),
	Ngaybatdau smalldatetime
	CONSTRAINT PK_NHANSU PRIMARY KEY (TenTK)
)
----them, xoa, sua
Insert into NHANSU values ('', '', '', '', '', '', '', '', '')
Delete from NHANSU where TenTK=''
Update NhanSu set Matkhau='' where TenTK=''
Update NhanSu set HoTen='' where TenTK=''
Update NhanSu set Gioitinh='' where TenTK=''
Update NhanSu set NgSinh='' where TenTK=''
Update NhanSu set Email='' where TenTK=''
Update NhanSu set Sodienthoai='' where TenTK=''
Update NhanSu set Chucvu='' where TenTK=''
Update NhanSu set Ngaybatdau='' where TenTK=''

---Quan ly nhan su
Select *from NHANSU