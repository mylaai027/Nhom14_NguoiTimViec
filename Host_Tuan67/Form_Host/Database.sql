Create Database NguoiTimViec
Go

Use NguoiTimViec
Go

Create Table NganhNghe
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,	
)
Go

Create Table KinhNghiem
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,
)
Go

Create Table MucLuong
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,
)
Go

Create Table KhuVuc
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,
)
Go

Create Table TrinhDo
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,
)
Go

Create Table HinhThucLamViec
(
	ID int identity primary key NOT NULL,
	Mota nvarchar(50) NOT NULL,
)
Go

Create Table NguoiTimViec
(
	HoTen nvarchar(50) NOT NULL,
	NgaySinh datetime NOT NULL,
	CMND nvarchar(9) primary key NOT NULL,
	DienThoai nvarchar(15) NOT NULL,
	Email nvarchar(50) NOT NULL,	
	NganhNghe int foreign key references NganhNghe(ID) NOT NULL,
	NganhNgheKhac nvarchar(30),
	KhuVuc int foreign key references KhuVuc(ID) NOT NULL,
	KhuVucKhac nvarchar(50),
	KinhNghiem int foreign key references KinhNghiem(ID) NOT NULL,
	HinhThucLamViec int foreign key references HinhThucLamViec(ID) NOT NULL,
	TrinhDo int foreign key references TrinhDo(ID) NOT NULL,
	TrinhDoKhac nvarchar(50),
	MucLuong int foreign key references MucLuong(ID) NOT NULL,
)
Go

 
 INSERT INTO HinhThucLamViec VALUES
 (N'Nhân Viên Chính Thức')
 GO
 INSERT INTO HinhThucLamViec VALUES
 (N'Nhân Viên Bán Thời Gian')
 GO
 INSERT INTO HinhThucLamViec VALUES
 (N'Nhân Viên Thời Vụ')
 GO
 INSERT INTO HinhThucLamViec VALUES
 (N'Nhân Viên Ngoài Giờ Hành Chính')
 GO
 INSERT INTO HinhThucLamViec VALUES
 (N'Làm Việc Online')
 GO
 INSERT INTO HinhThucLamViec VALUES
 (N'Sinh Viên Thực Tập')
 GO
 
 
 
 INSERT INTO KhuVuc VALUES
 (N'TP Hồ Chí Minh')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Hà Nội')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Hải Phòng')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Đà Nẵng')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Huế')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Bình Dương')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Đồng Nai')
 GO
 INSERT INTO KhuVuc VALUES
 (N'Khác')
 GO
 
 
 
 INSERT INTO KinhNghiem VALUES
 (N'Học Sinh/ Sinh Viên')
 GO
 INSERT INTO KinhNghiem VALUES
 (N'Sinh Viên mới tốt nghiệp')
 GO
 INSERT INTO KinhNghiem VALUES
 (N'1,2 Năm Kinh Nghiệm')
 GO
 INSERT INTO KinhNghiem VALUES
 (N'3->5 Năm Kinh Nghiệm')
 GO
 INSERT INTO KinhNghiem VALUES
 (N'Trên 5 Năm Kinh Nghiệm')
 GO
 
 
 INSERT INTO MucLuong VALUES
 (N'Thỏa Thuận')
 GO
 INSERT INTO MucLuong VALUES
 (N'<2 Triệu/Tháng')
 GO
 INSERT INTO MucLuong VALUES
 (N'>2 Triệu/Tháng -> <5 Triệu/Tháng')
 GO
 INSERT INTO MucLuong VALUES
 (N'>5 Triệu/Tháng -> <10 Triệu/Tháng')
 GO
 INSERT INTO MucLuong VALUES
 (N'>10 Triệu/Tháng')
 GO
 
 
 
 INSERT INTO NganhNghe VALUES
 (N'Bất Kỳ')
 GO
  INSERT INTO NganhNghe VALUES
 (N'Bán hàng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Bán hàng/Kinh doanh mạng lưới')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Báo chí/Biên tập viên')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Bảo hiểm/Tư vấn')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Bảo vệ/Vệ sĩ/An ninh')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Bất động sản')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Biên dịch/Phiên dịch')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Bưu chính viễn thông')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Chăm sóc khách hàng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Cơ khí/Kĩ thuật ứng dụng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Công nghệ thông tin')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Dầu khí/Địa chất')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Dệt may')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Du lịch/Nhà hàng/Khách sạn')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Dược/Hóa chất/Sinh hóa')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Giải trí/Vui chơi')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Giáo dục/Đào tạo/Thư viện')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Giao thông/Vận tải/Thủy Lợi/Cầu Đường')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Giày da/Thuộc da')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Hành chính/Thư ký')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Khác')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Kho vận/Vật tư')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Khu chế xuất/Khu công nghiệp')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Kiến trúc/Nội thất')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Kinh doanh')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Làm đẹp/Thể lực/Spa')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Lao động phổ thông')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Luật/Pháp lý')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Môi trường/Xử lý chất thải')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Mỹ phẩm/Thời trang/Trang sức')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Ngân hàng/Chứng khoán/Đầu tư')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Nghệ thuật/Điện ảnh')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Ngoại ngữ')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Nhân sự')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Nông/Lâm/Ngư nghiệp')
 GO
 INSERT INTO NganhNghe VALUES
 (N'PG/PB/Lễ tân')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Quan hệ đối ngoại')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Quản lý điều hành')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Quảng cáo/Marketing/PR')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Sản xuất/Vận hành sản xuất')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Sinh viên/Mới tốt nghiệp/Thực tập')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Tài chính/Kế toán/Kiểm toán')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Tài xế/Lái xe/Giao nhận')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Thẩm định/Giám định/Quản lý chất lượng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Thể dục/Thể thao')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Thiết kế/Mỹ thuật')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Thời vụ/Bán thời gian')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Thực phẩm/DV ăn uống')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Trang thiết bị công nghiệp')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Trang thiết bị gia dụng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Trang thiết bị văn phòng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Xây dựng')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Xuất-Nhập khẩu/Ngoại thương.')
 GO
 INSERT INTO NganhNghe VALUES
 (N'Y tế')
 GO
 
 
 
 INSERT INTO TrinhDo VALUES
 (N'Khác')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Lao Động Phổ Thông')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Chứng Chỉ')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Trung Học')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Trung Cấp')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Cao Đẳng')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Đại Học')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Cao Học')
 GO
 INSERT INTO TrinhDo VALUES
 (N'Tu Nghiệp Nước Ngoài')
 GO
 
 
 INSERT INTO NguoiTimViec(HoTen,NgaySinh,CMND,DienThoai,Email,NganhNghe,KhuVuc,KinhNghiem,HinhThucLamViec,TrinhDo,MucLuong) VALUES
 (N'NguyenVanA','10/24/1980','013245678','0901234567','A@Mail.test',4,1,3,4,6,3)
 GO
 INSERT INTO NguoiTimViec(HoTen,NgaySinh,CMND,DienThoai,Email,NganhNghe,KhuVuc,KinhNghiem,HinhThucLamViec,TrinhDo,MucLuong) VALUES
 (N'Test1','7/5/1991','012336789','0901234567','A@Mail.test',34,3,3,4,6,4)
 GO
 INSERT INTO NguoiTimViec(HoTen,NgaySinh,CMND,DienThoai,Email,NganhNghe,KhuVuc,KinhNghiem,HinhThucLamViec,TrinhDo,MucLuong) VALUES
 (N'Test2','5/5/1990','012323789','0901234567','A@Mail.test',38,1,3,4,6,4)
 GO
 INSERT INTO NguoiTimViec(HoTen,NgaySinh,CMND,DienThoai,Email,NganhNghe,KhuVuc,KinhNghiem,HinhThucLamViec,TrinhDo,MucLuong) VALUES
 (N'Test3','5/5/1990','012556789','0901234567','A@Mail.test',32,2,4,1,3,1)
 GO
 
 select aa.HoTen, aa.NgaySinh,aa.CMND,aa.DienThoai,aa.Email,a.Mota,aa.NganhNgheKhac,b.Mota,aa.KhuVucKhac,c.Mota,d.Mota,e.Mota,aa.TrinhDoKhac,f.Mota 
 from NguoiTimViec aa, NganhNghe a,KhuVuc b,KinhNghiem c,HinhThucLamViec d,TrinhDo e,MucLuong f
 where aa.NganhNghe=a.ID and aa.KhuVuc=b.ID and aa.KinhNghiem=c.ID and aa.HinhThucLamViec=d.ID and aa.TrinhDo=e.ID and aa.MucLuong=f.ID
 go
 
