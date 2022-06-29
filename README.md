# Đầy Là Phần Mềm Quản lí Quán Net Với 3 Role :

+ Admin 
+ Employee 
+ Custormer 
 
# Sử Dụng Font End : Winform 
# Back End : Entity Frame work , Linq to entity 


+ Chức Năng : 
+ Quản Lí Quán Net

********Sơ lược   
- Admin
	+ Quản Lí ca làm việc 
	+ Quản lí khách hàng 
	+ Quản lí nhân viên
	+ Quản lí sản phẩm
	+ Quản lí danh mục  
	+ Báo Cáo 

- Nhân viên

	+ quản lí tài khoản
  		+ Thêm , Xóa , Cập Nhập 
  		+ nạp tiền , khóa , mở 
	+ Thanh toán dịch vụ cho khách hàng 
	+ Bắt đầu ca làm việc , kết thúc ca làm việc  
	+ chat ( tương lai ) 

- Khách hàng
	+ nạp tiền
	+ chọn máy	
	+ gọi dịch vụ
	+ chat ( tương lai )



Phân Tích rõ ***********************************
- Quản lý khách hàng:         // viên
	 (-) Quản lí Lịch sử dùng dịch vụ
		+ Số máy
		+ Tên khách hàng
		+ Số giờ đã sử dụng (nếu hoạt động)
		+ Tổng chi phí (bên thu phí)
 	(-) Quản lí danh sách khách hàng : 
		(-) Sửa ,xóa
		(-) Thêm khách hàng sử dụng

************************************
- Quản Lí Nhân Viên 
  + Thêm , Sửa , Xóa , Cập Nhập         // Huy 
  + Tăng lương , Giảm Lương         // Huy
  + Chấm Công          //  Viên Huy Research
  + Trả Lương         // 

*********************************

- Quản lý sản phẩm:
	(-) Quản lý giá :   // vien
			+ Giá sản phẩm nhập
			+ Giá  sản phẩm xuất
			+ Tên sản phẩm
			+ ID sản phẩm
		(+) Chức năng : Xóa, sửa giá bán
	(-) Quản lý hàng : + Tên sản phẩm                  / Vien
         					+ ID sản phẩm
					+ Ngày nhập sản phẩm
					+ Hạn sử dụng
		(+) Chức năng : Sửa tên, Thêm sản phẩm khi nhập hàng
       (-)quản lịch sử sử dụng           / viên 				
		+ Số thứ tự
		+ Tên khách hàng sử dụng
		+ Ngày sử dụng
		+ Tên sản phẩm
		+ Mã sản phẩm
		+ Số lượng
		+ Giá tiền 1 sản phẩm
	 (+) chức năng thêm sửa xóa

*************************************

- Báo Cáo 
  + Doanh Thu theo ngày , tháng 
  + thu nhập 
  + Khách hàng nợ
*********************************
 
- Quản lí danh mục       // Huy
 + Danh mục đồ uống 
 + danh mục đồ ăn
 + danh mục dịch vụ


**************************
Quản lý ca làm việc:                 ////       Viên , Huy research 
+Tao và sắp Xếp ca làm việc theo ca , Xoay ca.    
+xem danh sách ca làm việc
+Sửa, xóa ca làm việc

*******************
Chấm công : 
	(-) Thuộc tính trong cột :
		+ ID_Employee
		+ NameEmployee
		+ StartDateTime : Khi đăng nhập vào sẽ set theo DateTime.Now
		+ EndDatetime : Khi đăng xuất sẽ set theo DateTime.Now
		+ WorkedHour : EndDateTime - StartDateTime
	(-) Tạo thêm 1 class "HourWorking" chứa thông tin : là số giờ đã làm
		+ StartDateTime: giờ nhân viên bắt đầu làm việc
		+ EndDatetime : giờ nhân viên kết thúc làm việc
		+ WorkedHour : số giờ đã làm
		+ TotalWorking : bằng tổng tất cả giờ trong cột WorkedHour tính từ hiện tại trở lên
	(-) Chức năng :
		+ Tự động thêm khi nhân viên đăng nhập vào hệ thống
		+ View theo ngày (theo combobox addRange Dictinc), theo nhân viên
		+ Sort theo số giờ làm trong 1 ngày, số giờ làm trong 1 tháng


Quản lý ca làm việc :
	(-) Sửa lại class Shift:
		+ StartDateTime : giờ bắt đầu của ca
		+ EndDatetime : giờ kết thúc của ca
		+ WorkedHour : số giờ làm của ca


	(-) Thuộc tính trong cột :
		+ ID_Employee
		+ NameEmployee
		+ StartDateTime
		+ EndDatetime
		+ WorkedHour
	(-) Chức năng :
		+ View All, theo từng nhân viên, Theo ngày chọn (theo combobox addRange Dictinc)
		+ Sort theo số giờ ca làm
		+ Delete ca làm
		+ Add ca
