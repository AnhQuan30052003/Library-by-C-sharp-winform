-- Tạo
create database QLTV
use QLTV

-- Xóa
use master
drop database QLTV

--[01] Độc giả
create table DocGia (
	maDG varchar(5) primary key,
	hoDem nvarchar(30) not null,
	ten nvarchar(20) not null,
	ngaySinh date null,
	gioiTinh nvarchar(5) not null,
	diaChi nvarchar(100) not null,
	dienThoai varchar(12) not null,
	soSachMuonDuoc int not null
)

--[02] Loại sách
create table LoaiSach (
	maLS varchar(5) primary key,
	tenLS nvarchar(50) not null
)

--[03] Sách
create table Sach (
	maSach varchar(5) primary key,
	maLS varchar(5) foreign key references LoaiSach(maLS),
	tenSach nvarchar(50) not null,
	moTa nvarchar(256) not null,
	soTrang int not null,
	giaTien int not null,
	soLuong int not null,
	ngonNgu nvarchar(20) not null,
)

--[03] Tác giả
create table TacGia (
	maTG varchar(5) primary key,
	tenTG nvarchar(50) not null,
)

--[05] Tác giả - Sách
create table TacGia_Sach (
	maSach varchar(5) foreign key references Sach(maSach),
	maTG varchar(5) foreign key references TacGia(maTG),
	namXB int not null,
	primary key (maSach, maTG)
)

--[06] Thủ thư
create table ThuThu (
	maTT varchar(5) primary key,
	hoDem nvarchar(30) not null,
	ten nvarchar(20) not null,
	ngaySinh date null,
	gioiTinh nvarchar(5) not null,
	diaChi nvarchar(100) not null,
	dienThoai varchar(12) not null,
)

--[07] Đăng ký
create table DangKy (
	maTT varchar(5) foreign key references ThuThu(maTT),
	maDG varchar(5) foreign key references DocGia(maDG),
	ngayDangKy date not null,
	ngayHetHan date not null,
	primary key (maTT, maDG, ngayDangKy)
)

--[08] Mượn sách
create table MuonSach (
	maTT varchar(5) foreign key references ThuThu(maTT),
	maSach varchar(5) foreign key references Sach(maSach),
	maDG varchar(5) foreign key references DocGia(maDG),
	ngayMuon date not null,
	ngayPhaiTra date not null,
	tienPhat int not null,
	primary key (maTT, maSach, maDG, ngayMuon)
)

--[09] Tài khoản đăng nhập
create table DangNhap (
	maTT varchar(5) foreign key references ThuThu(maTT),
	matKhau nvarchar(50) not null
	primary key (maTT)
)

-- Dữ liệu tạm nghiên cứu
insert into LoaiSach values
('LS001',N'Tiểu thuyết'),
('LS002',N'Ngôn tình'  ),
('LS003',N'Tra thám'   ),
('LS004',N'Tham khảo'  ),
('LS005',N'Khoa học'   ),
('LS006',N'Tôn giáo'   ),
('LS007',N'Lịch sử'    ),
('LS008',N'Nấu ăn'     ),
('LS009',N'Kỹ năng'    ),
('LS010',N'Self - Help')

insert into Sach values
('SA001','LS001' ,N'Harry Potter và Hòn Đá Phù Thủy'         ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'266','12700', 10, N'Tiếng Anh' ),
('SA002','LS001' ,N'Harry Potter và Phòng Chứa Bí Mật'       ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'312','13000', 10, N'Tiếng Anh' ),
('SA003','LS001' ,N'Harry Potter và tên Tù Nhân Ngục Askaban',N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'288','13500', 10, N'Tiếng Anh' ),
('SA004','LS001' ,N'Harry Potter và Chiếc Cốc Lửa'           ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'231','13000', 10, N'Tiếng Anh' ),
('SA005','LS001' ,N'Harry Potter và Hội Phượng Hoàng'        ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'266','13000', 10, N'Tiếng Anh' ),
('SA006','LS001' ,N'Harry Potter và Hoàng Tử Lai'            ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'320','15500', 10, N'Tiếng Anh' ),
('SA007','LS001' ,N'Harry Potter và Bảo Bối Tử Thần'         ,N'Thuộc bộ truyện Harry Potter của nhà văn J.K.Rowling'            ,'350','19900', 10, N'Tiếng Anh' ),
('SA008','LS002' ,N'Mắt Biếc'                                ,N'Cuốn sách nói về tình yêu thanh thiếu niên'                      ,'235','29900', 10, N'Tiếng Việt'),
('SA009','LS001' ,N'Những Đứa Con Rải Rác Trên Đường'        ,N'Cuốn sách nói về cuộc sống xã hội bất công với những đứa trẻ'    ,'428','17500', 07, N'Tiếng Việt'),
('SA010','LS001' ,N'Đà Lạt -Một thời phương xa'              ,N'Cuốn sách nói về cuộc sống của người dân Đà Lạt'                 ,'400','10600', 10, N'Tiếng Việt'),
('SA011','LS001' ,N'Dòng song không trở lại'                 ,N'Nói về những Những ký ức tười đẹp của tuổi thanh xuân'           ,'639','21000', 12, N'Tiếng Việt'),
('SA012','LS001' ,N'Cho tôi xin một vé đi tuổi thơ'          ,N'Nói về những kỹ niệm tưởng nhớ tuổi thơ'                         ,'350','9000' , 10, N'Tiếng Việt'),
('SA013','LS001' ,N'Bên nhau trọn đời'                       ,N'Nói về những biến cố diễn ra của 2 nhân vật chính'               ,'545','17500', 20, N'Tiếng Việt'),
('SA014','LS002' ,N'Truyện Kiều'                             ,N'Nói về Cuộc sống chông gai của người con gái thời xưa'           ,'450','7000' , 10, N'Tiếng Việt'),
('SA015','LS003' ,N'Dế mèn phiêu lưu ký'                     ,N'Nói về những cuộc phiêu lưu hấp dẫn của chú dế mèn'              ,'300','4000' , 21, N'Tiếng Việt'),
('SA016','LS003' ,N'Thiên đường mười giờ'                    ,N'Nói về những mĩ quan đẹp trên thế giới vào đúng thời điểm'       ,'471','10000', 12, N'Tiếng Việt'),
('SA017','LS007' ,N'Đất rừng Phương Nam'                     ,N'Nói về những mỹ quan, văn hóa của người dân Đất Nam'             ,'322','20000', 10, N'Tiếng Việt'),
('SA018','LS001' ,N'Sông Đời'                                ,N'Nói về những thăng trầm chông gai của cuộc đời và cách vượt qua' ,'762','21000', 19, N'Tiếng Việt'),
('SA019','LS001' ,N'Gạo nếp gạo tẻ'                          ,N'Nói về những định kiến nam và nữ trong xã hội ngày xưa và nay'   ,'452','6900' , 22, N'Tiếng Anh' ),
('SA020','LS010' ,N'Nhà giả Kim'                             ,N'Nói về cậu bé chăn cừu và cuộc đời của cậu'                      ,'500','11000', 10, N'Tiếng Anh' ),
('SA021','LS010' ,N'Đắc nhân tâm'                            ,N'Nói về những cách sống và chỉ dạy cách sống đúng nghĩa'          ,'472','12000', 30, N'Tiếng Anh' ),
('SA022','LS010' ,N'Cách nghĩ để thành công'                 ,N'Nói về những cách suy nghĩ tích cực để có được thành công'       ,'312','4500' , 10, N'Tiếng Anh' ),
('SA023','LS010' ,N'Quảng gánh lo đi và vui sống'            ,N'Nói về những gánh nặng của cuộc sống và cách vượt qua chúng'     ,'450','9900' , 22, N'Tiếng Anh' ),
('SA024','LS010' ,N'Đọc vị bất kỳ ai'                        ,N'Nói về những cách đọc vị, nắm bắt được tâm lý của người khác'    ,'378','7500' , 10, N'Tiếng Anh' ),
('SA025','LS001' ,N'Tiểu thuyết bố già'                      ,N'Nói về cuộc sống của những người bố trong gia đình'              ,'558','10000', 10, N'Tiếng Anh' ),
('SA026','LS010' ,N'Cuộc sống không giới hạn'                ,N'Nói về cách sống ý nghĩa khi chúng ta còn có thể'                ,'613','9700' , 10, N'Tiếng Anh' ),
('SA027','LS010' ,N'Đời thay đổi khi chúng ta thay đổi'      ,N'Chỉ dẫn chúng ta sống đúng là tích cực để thay đổi cuộc sống'    ,'905','15000', 12, N'Tiếng Anh' ),
('SA028','LS010' ,N'Người giàu có nhất thành BabyLon'        ,N'Dạy chúng ta suy nghĩ như những người có tiền'                   ,'412','8500' , 18, N'Tiếng Anh' )

insert into TacGia values
('TG001', N'Nguyễn Nhật Ánh'	),
('TG002', N'Hồ Anh Thái'		),
('TG003', N'Phạm Duy'			),
('TG004', N'Vi Thùy Linh'		),
('TG005', N'J.K.Rowling'		),
('TG006', N'Vũ Trọng Phụng'		),
('TG007', N'Nguyễn Du'			),
('TG008', N'Trích Tân'			),
('TG009', N'Lê Lựu'				),
('TG010', N'Huyền Anh'			),
('TG011', N'Đoàn Thạch Biền'	),
('TG012', N'Bùi Anh Tuấn'		),
('TG013', N'Nguyễn Văn Thiệu'	),
('TG014', N'Hồ Biểu Chánh'		),
('TG015', N'Paulo Coelho'		),
('TG016', N'NDale Carnegie'		),
('TG017', N'Napoleon Hill'		),
('TG018', N'David J.Lieberman'	),
('TG019', N'Mario Puzo'			),
('TG020', N'Nick Vujicic'		),
('TG021', N'Andrew Matthews'	),
('TG022', N'George Samuel Clason')

insert into TacGia_Sach values
('SA001','TG005','1990'),
('SA002','TG005','2001'),
('SA003','TG005','2003'),
('SA004','TG005','2005'),
('SA005','TG005','2007'),
('SA006','TG005','2009'),
('SA007','TG005','2008'),
('SA008','TG001','2005'),
('SA009','TG002','2010'),
('SA010','TG003','2010'),
('SA011','TG004','2010'),
('SA012','TG001','2010'),
('SA013','TG008','2010'),
('SA014','TG007','2010'),
('SA015','TG012','2010'),
('SA016','TG009','2010'),
('SA017','TG014','2010'),
('SA018','TG011','2010'),
('SA019','TG010','2010'),
('SA020','TG015','2013'),
('SA021','TG016','2011'),
('SA022','TG017','1999'),
('SA023','TG018','1976'),
('SA024','TG019','2004'),
('SA025','TG020','2011'),
('SA026','TG021','2003'),
('SA027','TG022','1988'),
('SA028','TG006','2010')

insert into ThuThu values
('TT001', N'Nguyễn Anh', N'Quân', '2003-05-30', N'Nam', N'Nha Trang', '0398090114'),
('TT002', N'Trầm Quang', N'Vinh', '2003-08-28', N'Nam', N'Nha Trang', '0925474047'),
('TT003', N'Nguyễn Phú', N'Sỹ',   '2003-10-14', N'Nam', N'Nha Trang', '0398090115')

insert into DocGia values
('DG001', N'Nguyễn Tấn' , N'Lập','2003-09-04' ,'Nam', N'Vạn Giã - Khánh Hòa' ,'0886054333', 3),
('DG002', N'Nguyễn Quốc', N'Huy','2003-01-18' ,'Nam', N'Vạn Giã - Khánh Hòa' ,'0886054335', 3)

insert into DangKy values
('TT001','DG001','2023-03-20','2024-03-20'),
('TT002','DG002','2023-03-25','2024-03-25')

insert into MuonSach values
('TT001','SA001','DG001','2023-03-20','2023-03-27', 5000)

insert into DangNhap values
('TT001', '1'),
('TT002', '1'),
('TT003', '1')