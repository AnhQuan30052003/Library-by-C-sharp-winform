use QLTV
use master

-- CÂU 03: TẠO 35 CÂU TRUY VẤN
-- [A]: Truy vấn đơn giản: (3 câu)
-- 01: Hiển thị sách theo chiều giảm dần giá bìa
select * from Sach
order by giaTien desc

-- 02: Hiển thị thông tin các tác giả
select * from TacGia

-- 03: Hiển thị thông tin của các thủ thư
select * from ThuThu


-- [B]: Truy vấn với AGGREGATE FUNCTIONS: (7 câu)
-- 01: Có bao nhiêu sách được mượn trong năm 2023 ?
select count(maSach) as 'Số sách đã cho mượn' 
from MuonSach ms
where year(ms.ngayMuon) = 2023

-- 02: Cho biết số tiền trung bình trang sách của thư viện ?
select avg(s.giaTien) as 'số tiền trung bình'
from Sach s 

-- 03: Cho biết mã sách, tên sách mà có mã tác giả là 'TG001' ?
select s.maSach, TenSach 
from Sach s, TacGia_Sach tgs
where s.maSach = tgs.maSach 
	and tgs.maTG = 'TG001' 

-- 04: Cho biết thông tin gồm mã sách tên sách, tên thủ thư mà thủ thư đó có mã số thủ thư TT002 đã lập danh sách mượn sách?
select s.maSach, s.tenSach, hoDem + ' ' + Ten as 'họ tên thủ thư'
from Sach s, thuthu tt, muonSach ms
where s.maSach = ms.maSach 
		and ms.maTT = tt.maTT
		and ms.maTT = 'TT002'

-- 05: Cho biết mã số tác giả, tên tác giả, tên sách mà năm xuất bản bé hơn năm 1950?
select TG.MATG, tg.TenTG, s.TenSach
FROM TACGIA TG, Sach S, TacGia_Sach TGS
WHERE TG.maTG = TGS.maTG
		AND S.maSach = TGS.maSach 
		AND TGS.namXB < 1950 

-- 06: Cho biết số tiền trung bình trang bìa mà tác giả có mã số tg001 đã sản xuất sách và năm xuất bản >=2000?
select avg(giaTien) as 'số tiền trung bình trang bìa của tác giả 001'
from TacGia_Sach TGS, Sach s 
where tgs.maSach = s.maSach and tgs.namXB >= 2000

-- 07: Có bao nhiêu đọc giả được thủ thư có mã số thủ thư TT003 lập đăng ký trong năm 2023?
select count(dg.madg) as 'số lượng đọc giả thủ thư đã lập'
from DocGia dg, ThuThu tt, DangKy dk
where dg.maDG = dk.maDG and tt.maTT = dk.maTT and tt.maTT = 'TT003' and year(dk.ngayDangKy) = 2023


-- [C]: Truy vấn với mệnh đề HAVING: (5 câu)
-- 01: Cho biết tên những độc giả chỉ mượn sách đúng 1 lần
select hoDem + ' ' + ten as [ho ten]
from DocGia dg join MuonSach ms on dg.maDG = ms.maDG
group by hoDem + ' ' + ten
having count(*) = 1

-- 02: Cho biết tên những độc giả mượn sách hơn 5 lần
select hoDem + ' ' + ten as [ho ten]
from DocGia dg join MuonSach ms on dg.maDG = ms.maDG
group by hoDem + ' ' + ten
having count(*) > 5

-- 03: Cho biết mã và tên tác giả viết đúng 1 quyển sách
select tg.tenTG
from TacGia tg join TacGia_Sach tgs on tg.maTG =tgs.maTG
group by tg.tenTG
having count(*) = 1

-- 04: Cho biết tên thủ thư đã đăng ký cho mượn sách đúng 1 lần
select tt.hoDem + ' ' + tt.ten as [ho ten]
from ThuThu tt join MuonSach ms on tt.maTT = ms.maTT
group by tt.hoDem + ' ' + tt.ten
having count(*) = 1

-- 05: Cho biết tên thủ chưa đăng ký cho mượn sách hơn 5 lần trong tháng 2 năm 2023
select tt.hoDem + ' ' + tt.ten as [ho ten]
from ThuThu tt join MuonSach ms on tt.maTT = ms.maTT
where month(ngayMuon) = 2 and year(ngayMuon) = 2023
group by tt.hoDem + ' ' + tt.ten
having count(*) > 5

-- [D]: Truy vấn lớn nhất, nhỏ nhất: (3 câu)
-- 01: Cho biết mã số sách, tên sách, số trang LỚN nhất của quyển sách có ngôn ngữ là tiếng Anh
select top 1 maSach, TenSach, soTrang
from  Sach s
where ngonNgu = N'Tiếng Anh'
ORDER by soTrang DESC 

--02: Cho biết tên của quyển sách thuộc ngôn ngữ nào có số tiền giá bìa thấp nhất 
select TenSach as 'tên sách', ngonNgu as 'ngôn ngữ', giaTien as 'Giá Bìa'	
from Sach s 
where giaTien = (select min(giaTien) from Sach s)

-- 03: Cho biết maTT, tên thủ thư , số lượng lập phiếu mượn. thủ thư nào lập phiếu mượn sách nhiều nhất tính từ năm 2023 và tháng < 10
select  tt.maTT , tt.HoDem + ' ' + tt.Ten as 'họ tên thủ thư', count( ms.maTT) as 'số lượng lập phiếu'
from thuthu tt, muonSach ms
where tt.maTT = ms.maTT and year(ngayMuon) = 2023 and month(ngayMuon) <10
group by tt.maTT , tt.HoDem + ' ' + tt.Ten 
having count(ms.maTT) = (
	select top 1 count(*)
	from MuonSach 
	group by maTT
)


-- [E]: Truy Vấn KHÔNG/CHƯA CÓ: (5 câu)
-- 01: Cho biết tên những độc giả chưa mượn sách
select *
from DocGia
where maDG not in (select maDG from MuonSach)

-- 02: Cho biết tên những những thủ thư chưa tham gia đăng ký mượn sách
select hoDem + ' ' + ten as [ho ten]
from ThuThu
where maTT not in (select distinct maTT from MuonSach)

-- 03: Cho biết tên những cuốn sách không xuất bản trước năm 2000
select tenSach
from Sach
where maSach not in (
	select maSach
	from TacGia_Sach
	where namXB < 2000
)

-- 04: Cho biết tên những cuốn sách không phải do tác giả "Nguyễn Nhật Ánh" viết
select tenSach
from Sach
where maSach not in (
	select maSach
	from TacGia_Sach a join TacGia b on a.maTG = b.maTG
	where b.tenTG like N'Nguyễn Nhật Ánh'
)

-- 05: Cho biết tên những độc giả đã mượn sách nhưng chưa trả
select dg.hoDem + ' ' + dg.ten as [ho ten]
from DocGia dg join MuonSach ms on dg.maDG = ms.maDG
where ngayPhaiTra < GetDate();


-- [F]: Truy vấn HỢP/GIAO/TRỪ: (3 câu)
-- 01: (phép hợp)liệt kê thông tin (maSach, TenSach) các quyển sách được mượn mà có thủ thư có mã số Th001 hoặc TH002 đều lập(Union)
select s.maSach, s.TenSach
from Sach s, MuonSach ms
where s.maSach = ms.maSach and ms.maTT = 'TT001'
union
select s.maSach, s.TenSach
from Sach s, MuonSach ms
where s.maSach = ms.maSach and ms.maTT = 'TT002'

-- 02: (phép giao)liệt kê độc giả có mượn sách tại thư viện trong từ tháng 02 đến tháng 09(Intersect)
select DG.maDG, DG.Ten
from MuonSach ms, DocGia DG
where ms.maDG = DG.maDG and Month(ngayMuon) >= 02
intersect
select DG.maDG, DG.Ten
from MuonSach ms, DocGia DG
where ms.maDG = DG.maDG and Month(ngayMuon) <= 09

-- 03: (phép trừ)liệt kê các thủ thư lập đăng ký thẻ độc giả vào tháng <03 nhưng không lập phiếu mượn sách vào tháng 03(Except)
select distinct tt.maTT, Ten
from ThuThu tt, DangKy dk
where tt.maTT= dk.maTT and month(ngayDangKy) = 03
Except
select distinct tt.maTT, Ten
from ThuThu tt, MuonSach ms
where tt.maTT = ms.maTT and month(ngayMuon) = 03


-- [G]: Truy vấn UPDATE/DELETE: (7 câu)
-- 01: Tăng giá bìa lên gấp đôi cho những sách có nguôn ngữ là "tiếng anh"
update Sach 
set giaTien=giaTien*1.2
from Sach 
Where ngonNgu like 'Tiếng Anh'

-- 02: Xóa những cuốn sách có giá tiền < 10000
delete Sach
where giaTien < 10000

-- 03: Xóa dữ liệu bảng mượn sách
delete MuonSach

-- 04: Xóa thông tin của độc giả có mã là "DG001"
delete DocGia
where maDG = 'DG001'

-- 05: Xóa những sách không có độc giả nào mượn
delete Sach
where maSach not in (
	select maSach
	from MuonSach
)

-- 06: Xóa thông tin thủ thư có mã thủ thư "TT003"
delete ThuThu
where maTT = 'TT003'

-- 07: Xóa dữ liệu bảng tác giả
delete TacGia

 
-- [H]: Truy vấn sử dụng phép Chia: (2 câu)
-- 01: Cho biết tên thủ thư đã lập thẻ thư viện cho tất cả các đọc giả vào tháng 2 năm 2023
select tt.hoDem + ' ' + tt.Ten as [họ và tên]
from ThuThu tt
where not exists (
	select * from DangKy dk
	where month(ngayDangKy) = 2 and year(ngayDangKy) = 2023
		and not exists (
			select * from ThuThu tt#
			where tt#.maTT = tt.maTT
				and tt#.maTT = dk.maTT
		)
)

-- 02: Cho biết tên thủ thư đã cho mượn tất cả sách của tác giả 'Nguyễn Nhật Ánh'
select tt.hoDem + ' ' + tt.Ten as [họ và tên]
from ThuThu tt
where not exists (
	select *
	from TacGia_Sach tgs join TacGia tg on tgs.maTG = tg.maTG
	where tg.TenTG = N'Nguyễn Nhật Ánh'
		and not exists (
			select * from MuonSach ms
			where ms.maTT = tt.maTT
				and ms.maSach = tgs.maSach
		)
)

---------------------------------------------------------------------------------------------------------------------------------------------------
-- CÂU 04: TẠO ÍT NHẤT 5 THỦ TỤC HÀM VÀ 3 TRIGGER
-- Thủ tục hàm
-- [01]: Lưu Loại Sách
create proc Luu_LoaiSach (
	@maLS varchar(5), @tenLS nvarchar(100)
) as begin
	if @maLS not in (select maLS from LoaiSach)	begin
		insert into LoaiSach values (@maLS, @tenLS)
	end
	else begin
		update LoaiSach
		set tenLS = @tenLS
		where maLS = @maLS
	end
end

-- [02]: Hiển thị thông tin của sách từ bảng (sách, tác giả & sách)
create proc ThongTin_Sach
as begin
	select s.maSach [Mã sách], tenSach [Tên sách], ls.tenLS [Loại sách], moTa [Mô tả], soTrang [Số trang], giaTien [Giá tiền], soLuong [Số lượng], ngonNgu [Ngôn ngữ], tenTG [Tên tác giả], namXB [Năm xuất bản]
	from Sach s join TacGia_Sach tgs on s.maSach = tgs.maSach
		join TacGia tg on tg.maTG = tgs.maTG
		join LoaiSach ls on ls.MaLS = s.maLS
end

-- [03] Tìm kiếm thông tin Sach
create proc TimThongTin_Sach (
	@s nvarchar(100)
)
as begin
	select s.maSach [Mã sách], tenSach [Tên sách], ls.tenLS [Loại sách], moTa [Mô tả], soTrang [Số trang], giaTien [Giá tiền], soLuong [Số lượng], ngonNgu [Ngôn ngữ], tenTG [Tên tác giả], namXB [Năm xuất bản]
	from Sach s join TacGia_Sach tgs on s.maSach = tgs.maSach
		join TacGia tg on tg.maTG = tgs.maTG
		join LoaiSach ls on ls.MaLS = s.maLS
	where s.maSach like '%' + @s + '%'
		or tenSach like '%' + @s + '%'
		or moTa like '%' + @s + '%'
		or soTrang like '%' + @s + '%'
		or giaTien like '%' + @s + '%'
		or soLuong like '%' + @s + '%'
		or ngonNgu like '%' + @s + '%'
		or tenTG like '%' + @s + '%'
		or namXB like '%' + @s + '%'
		or tenLS like '%' + @s + '%'
end

-- [04] Hàm lưu thông tin Sách
create proc Luu_Sach (
	@maSach varchar(5), @tenSach nvarchar(50), @moTa nvarchar(256), @soTrang int, @giaTien money, @soLuong int, @ngonNgu nvarchar(20),
	@tenTG nvarchar(50), @namXB int,
	@tenLS nvarchar(50)
) as begin
	declare @maTG varchar(5)
	set @maTG = (select maTG from TacGia where tenTG = @tenTG)

	declare @maLS varchar(5)
	set @maLS = (select maLS from LoaiSach where tenLS = @tenLS)

	if @maSach not in (select maSach from Sach) begin
		insert into Sach values (@maSach, @maLS, @tenSach, @moTa, @soTrang, @giaTien, @soLuong, @ngonNgu)
		insert into TacGia_Sach values (@maSach, @maTG, @namXB)
	end
	else begin
		update Sach
		set maLS = @maLS, tenSach = @tenSach, moTa = @moTa, soTrang = @soTrang, giaTien = @giaTien, soLuong = @soLuong, ngonNgu = @ngonNgu
		where maSach = @maSach

		update TacGia_Sach
		set maTG = @maTG, namXB = @namXB
		where maSach = @maSach
	end
end

-- [05]: Tìm kiếm thông tin TacGia
create proc TimThongTin_TacGia (
	@s nvarchar(100)
) as begin
	select maTG [Mã tác giả], tenTG [Tên tác giả] from TacGia
	where maTG like '%' + @s + '%'
		or tenTG like '%' + @s + '%'
end

-- [06]: Lưu tác giả
create proc Luu_TacGia (
	@maTG varchar(5), @tenTG nvarchar(50)
) as begin
	if @maTG not in (select maTG from TacGia) begin
		insert into TacGia values (@maTG, @tenTG)
	end
	else begin
		update TacGia
		set tenTG = @tenTG
		where maTG = @maTG
	end
end

-- [07]: Hiển thị thông tin độc giả từ bảng (độc giả, đăng ký)
create proc ThongTin_DocGia_DangKy
as begin
	select dg.maDG [Mã độc giả], hoDem [Họ đêm], ten [Tên], ngaySinh [Ngày sinh], gioiTinh [Giới tính], diaChi [Địa chỉ], dienThoai [Điện thoại], ngayDangKy [Ngày đăng ký], ngayHetHan [Ngày hết hạn], soSachMuonDuoc [Số sách mượn được]
	from DocGia dg join DangKy dk on dg.maDG = dk.maDG
end

-- [08]: Tìm thông tin độc giả
create proc TimThongTin_DocGia (
	@s nvarchar(100)
) as begin
	select dg.maDG [Mã độc giả], hoDem [Họ đêm], ten [Tên], ngaySinh [Ngày sinh], gioiTinh [Giới tính], diaChi [Địa chỉ], dienThoai [Điện thoại], ngayDangKy [Ngày đăng ký], ngayHetHan [Ngày hết hạn], soSachMuonDuoc [Số sách mượn được]
	from DocGia dg join DangKy dk on dg.maDG = dk.maDG
	where dg.maDG like '%' + @s + '%'
		or hoDem like '%' + @s + '%'
		or ten like '%' + @s + '%'
		or ngaySinh like '%' + @s + '%'
		or gioiTinh like '%' + @s + '%'
		or diaChi like '%' + @s + '%'
		or dienThoai like '%' + @s + '%'
		or ngayDangKy like '%' + @s + '%'
		or ngayHetHan like '%' + @s + '%'
end

-- [09]: Lưu độc giả
create proc Luu_DocGia (
	@maDG varchar(5), @hoDem nvarchar(30), @ten nvarchar(20), @ngaySinh date, @gioiTinh nvarchar(5), @diaChi nvarchar(100), @dienThoai varchar(12), @soSachMuonDuoc int,
	@maTT varchar(5), @ngayDangKy date, @ngayHetHan date
) as begin
	if @maDG not in (select maDG from DocGia) begin
		insert into DocGia values (@maDG, @hoDem, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @soSachMuonDuoc)
		insert into DangKy values (@maTT, @maDG, @ngayDangKy, @ngayHetHan)
	end
	else begin
		update DocGia
		set hoDem = @hoDem, ten = @ten, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, diaChi = @diaChi, dienThoai = @dienThoai, soSachMuonDuoc = @soSachMuonDuoc
		where maDG = @maDG
	end
end

-- [10]: Tìm thông tin thủ thư
create proc TimThongTin_ThuThu (
	@s nvarchar(100)
) as begin
	select maTT [Mã thủ thư], hoDem [Họ đệm], ten [Tên], ngaySinh [Ngày sinh], gioiTinh [Giới tính], diaChi [Địa chỉ], dienThoai [Điện thoại]
	from ThuThu
	where maTT like '%' + @s + '%'
		or hoDem like '%' + @s + '%'
		or ten like '%' + @s + '%'
		or ngaySinh like '%' + @s + '%'
		or gioiTinh like '%' + @s + '%'
		or diaChi like '%' + @s + '%'
		or dienThoai like '%' + @s + '%'
end

-- [11]: Lưu thủ thư
create proc Luu_ThuThu (
	@maTT varchar(5), @hoDem nvarchar(30), @ten nvarchar(20), @ngaySinh date, @gioiTinh nvarchar(5), @diaChi nvarchar(100), @dienThoai varchar(12)
) as begin
	if @maTT not in (select maTT from ThuThu) begin
		insert into ThuThu values (@maTT, @hoDem, @ten, @ngaySinh, @gioiTinh, @diaChi, @dienThoai)
		insert into DangNhap values (@maTT, '1')
	end
	else begin
		update ThuThu
		set hoDem = @hoDem, ten = @ten, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, diaChi = @diaChi, dienThoai = @dienThoai
		where maTT = @maTT
	end
end

-- [12]: Thông tin mượn sách
create proc ThongTin_MuonSach
as begin
	select s.maSach [Mã sách], tenSach [Tên sách], dg.hoDem + ' ' + dg.ten [Độc giả], dg.dienThoai [Số điện thoại], ngayMuon [Ngày mượn], ngayPhaiTra [Ngày phải trả], ms.tienPhat [Tiền phạt], tt.hoDem + ' ' + tt.ten [Thủ thư]
	from ThuThu tt join MuonSach ms on tt.maTT = ms.maTT
		join DocGia dg on dg.maDG = ms.maDG
		join Sach s on s.maSach = ms.maSach
end

-- [13]: Tìm kiếm thông tin sách mượn-trả
create proc TimThongTin_SachMuon (
	@s nvarchar(100)
) as begin
	select s.maSach [Mã sách], tenSach [Tên sách], dg.hoDem + ' ' + dg.ten [Độc giả], dg.dienThoai [Số điện thoại], ngayMuon [Ngày mượn], ngayPhaiTra [Ngày phải trả], ms.tienPhat [Tiền phạt], tt.hoDem + ' ' + tt.ten [Thủ thư]
	from ThuThu tt join MuonSach ms on tt.maTT = ms.maTT
		join DocGia dg on dg.maDG = ms.maDG
		join Sach s on s.maSach = ms.maSach
	where s.tenSach like '%' + @s + '%'
		or dg.hoDem + ' ' + dg.ten like '%' + @s + '%'
		or dg.DienThoai like '%' + @s + '%'
		or ngayMuon like '%' + @s + '%'
		or ngayPhaiTra like '%' + @s + '%'
		or tt.hoDem + ' ' + tt.ten like '%' + @s + '%'
		or s.maSach like '%' + @s + '%'
		or tt.maTT like '%' + @s + '%'
		or dg.maDG like '%' + @s + '%'
end

-- Trigger
-- [01]: Trigger xử lý khi mượn sách
create trigger KhiMuonSach on MuonSach
for insert
as begin
	update Sach
	set soLuong -= 1
	from inserted i
	where i.maSach = Sach.maSach

	update DocGia
	set soSachMuonDuoc -= 1
	from inserted i
	where i.maDG = DocGia.maDG
end

-- [02]: Trigger xử lý khi trả sách
create trigger KhiTraSach on MuonSach
for delete
as begin
	update Sach
	set soLuong += 1
	from deleted d
	where d.maSach = Sach.maSach

	update DocGia
	set soSachMuonDuoc += 1
	from inserted i
	where i.maDG = DocGia.maDG
end

-- [03]: Trigger xử lý khi thêm sách sai khác ngôn ngữ (Tiếng Anh hoặc Tiếng Việt)
create trigger KhacNgonNgu on Sach
for insert
as begin
	if (select i.ngonNgu from inserted i) not in (N'Tiếng Anh', N'Tiếng Việt') begin
		print N'Ngôn ngữ chỉ được là tiếng Anh hoặc tiếng Việt'
	end
end

---------------------------------------------------------------------------------------------------------------------------------------------------
-- CÂU 05: TẠO 3 NGƯỜI DÙNG VÀ CẤP QUYỀN KHÁC NHAU CHO MỖI NGƯỜI DÙNG
-- [02]:
create login quan with password = '123'
create user quan for login quan
grant create table to quan

-- [02]:
create login vinh with password = '123'
create user vinh for login vinh
grant delete to vinh

-- [03]:
create login sy with password = '123'
create user sy for login sy
grant alter to sy