# Buổi 02 – Danh sách

Họ tên: Lê Thành Long · MSV: 12425071



## Bài đã làm

Toàn bộ bài tập của buổi thực hành được tổ chức trong một project console C# (`Buoi02_DanhSach`). File `Program.cs` tích hợp menu chọn từng bài để người dùng nhập dữ liệu trực tiếp từ bàn phím và in kết quả tương ứng.

```

Buoi02_DanhSach/

├── README.md

├── Buoi02_DanhSach.csproj

└── Program.cs

```

| Menu | Hàm thực thi | Nội dung |

|:---:|---|---|

| 1 | `Bai1()` | Mảng 1 chiều: Nhập, hiển thị và chèn phần tử vào vị trí k |

| 2 | `Bai2()` | Quản lý danh sách nhân viên (tổng thực lĩnh, lương CB thấp nhất, đếm thưởng, sắp xếp, tăng lương 5%) |

| 3 | `Bai3()` | Ma trận vuông: Tính tổng, tìm số dương nhỏ nhất, tổng chéo phụ, kiểm tra chéo chính tăng dần |

| 4 | `Bai4()` | Danh sách liên kết đơn pHead: Đếm phần tử bằng x, tìm số dương nhỏ nhất, xóa x đầu tiên |

| 5 | `Bai5()` | Danh sách liên kết đơn l: Tìm max, tính tổng, đếm số nguyên tố, đếm âm/0/dương, đếm x, tìm min dương |

| 9 | `Bai9()` | Phân loại và thống kê số nguyên tố, số chẵn, số hoàn hảo trong dãy số |

| 10 | `Bai10()` | In ma trận theo thứ tự xoắn ốc |

| 11 | `Bai11()` | Kiểm tra ma trận đơn vị và ma trận đối xứng |

| 12 | `Bai12()` | Tạo bảng game Minesweeper kích thước m x n và tính số mìn xung quanh mỗi ô |

| 13 | `Bai13()` | Đảo ngược danh sách liên kết đơn không dùng đệ quy (dùng 3 con trỏ) |

| 14 | `Bai14()` | Gộp hai danh sách liên kết đã sắp xếp thành một danh sách sắp xếp |

| 15 | `Bai15()` | Kiểm tra danh sách liên kết có chứa chu trình (Giải thuật Floyd - Rùa và Thỏ) |

| 16 | `Bai16()` | Hệ thống lịch sử duyệt web (Back / Forward) bằng danh sách liên kết kép |

| 17 | `Bai17()` | Quản lý Playlist nhạc (Thêm, Xóa, Next, Previous) bằng danh sách liên kết kép |

| 18 | `Bai18()` | Hệ thống quản lý trạng thái đơn hàng bằng danh sách liên kết kép |



## Cách chạy

Chạy từ thư mục gốc của repo (cần cài .NET SDK 10.0):

```

dotnet run --project Buoi02_DanhSach

```

Chương trình hiện menu, nhập số thứ tự bài để chạy và nhập dữ liệu theo yêu cầu trên màn hình, nhập `0` để thoát.



## Kết quả chạy

Menu:

```

=== MENU BUOI 02 - DANH SACH ===

1. Bai 1

2. Bai 2

3. Bai 3

4. Bai 4

5. Bai 5

9. Bai 9

10. Bai 10

11. Bai 11

12. Bai 12

13. Bai 13

14. Bai 14

15. Bai 15

16. Bai 16

17. Bai 17

18. Bai 18

0. Thoat

Chon bai:

```

**Bài 1** – nhập mảng 4 phần tử và chèn 99 vào vị trí k = 2:

```

=== Bài 1 ===

Nhap so phan tu n: 4

a[0] = 10

a[1] = 20

a[2] = 30

a[3] = 40

b. Danh sach mang vua nhap: 10 20 30 40

Nhap gia tri can chen: 99

Nhap vi tri can chen k: 2

c. Danh sach sau khi chen: 10 20 99 30 40

```

**Bài 2** – nhập danh sách 3 nhân viên:

```

=== Bài 2 ===

Nhap so luong nhan vien: 3

Nhap nhan vien thu 1:

Ma NV: NV01

Ho va ten: Le Thanh Long

Nam sinh: 2006

Phong ban: IT

Luong co ban: 8000000

Thuong: 1500000

Nhap nhan vien thu 2:

Ma NV: NV02

Ho va ten: Nguyen Van An

Nam sinh: 2005

Phong ban: Ke toan

Luong co ban: 6500000

Thuong: 1200000

Nhap nhan vien thu 3:

Ma NV: NV03

Ho va ten: Tran Thi Binh

Nam sinh: 2006

Phong ban: IT

Luong co ban: 6500000

Thuong: 900000

a. Tong thuc linh thang cua cong ty: 24600000

b. Cac nhan vien co luong co ban thap nhat:

NV02	Nguyen Van An	2005	Ke toan	6500000	1200000	7700000

NV03	Tran Thi Binh	2006	IT	6500000	900000	7400000

c. So nhan vien co thuong >= 1200000 la: 2

d. Danh sach sau khi sap xep:

NV03	Tran Thi Binh	2006	IT	6500000	900000	7400000

NV01	Le Thanh Long	2006	IT	8000000	1500000	9500000

NV02	Nguyen Van An	2005	Ke toan	6500000	1200000	7700000

e. Danh sach sau khi tang luong 5%:

NV03	Tran Thi Binh	2006	IT	6825000	900000	7725000

NV01	Le Thanh Long	2006	IT	8400000	1500000	9900000

NV02	Nguyen Van An	2005	Ke toan	6825000	1200000	8025000

```

**Bài 3** – nhập ma trận vuông cấp n = 3:

```

=== Bài 3 ===

Nhap cap cua ma tran vuong n: 3

a[0,0] = 2

a[0,1] = -4

a[0,2] = 6

a[1,0] = 3

a[1,1] = 5

a[1,2] = 1

a[2,0] = 7

a[2,1] = 8

a[2,2] = 9

Ma tran vua nhap:

2	-4	6

3	5	1

7	8	9

a. Tong cac phan tu cua ma tran: 37

b. Gia tri duong nho nhat cua ma tran: 1

c. Tong cac phan tu tren duong cheo phu: 18

d. Duong cheo chinh tang dan

```

**Bài 4** – nhập danh sách 5 phần tử và x = 8:

```

=== Bài 4 ===

Nhap so luong phan tu cua danh sach: 5

Nhap phan tu thu 1: 15

Nhap phan tu thu 2: 8

Nhap phan tu thu 3: 23

Nhap phan tu thu 4: 8

Nhap phan tu thu 5: 4

Danh sach ban dau: 15 8 23 8 4

Nhap gia tri x can dem va xoa: 8

a. So phan tu bang 8 la: 2

b. Phan tu duong nho nhat la: 4

c. Danh sach sau khi xoa 8 dau tien: 15 23 8 4

```

**Bài 5** – nhập danh sách 6 phần tử và x = 7:

```

=== Bài 5 ===

Nhap so luong phan tu cua danh sach: 6

Nhap phan tu thu 1: -5

Nhap phan tu thu 2: 11

Nhap phan tu thu 3: 0

Nhap phan tu thu 4: 7

Nhap phan tu thu 5: 2

Nhap phan tu thu 6: 7

Danh sach l vua nhap: -5 11 0 7 2 7

a. Phan tu lon nhat: 11

b. Tong cac phan tu: 22

c. So luong so nguyen to: 4

d. So am: 1, So bang 0: 1, So duong: 4

Nhap so x can dem trong danh sach: 7

e. So phan tu bang 7 la: 2

f. Phan tu duong nho nhat: 2

```

**Bài 9** – nhập dãy 6 phần tử:

```

=== Bài 9 ===

Nhap so phan tu cua day so: 6

a[0] = 2

a[1] = 6

a[2] = 7

a[3] = 12

a[4] = 28

a[5] = 15

So nguyen to: 2 7 -> Co 2 so

So chan: 2 6 12 28 -> Co 4 so

So hoan hao: 6 28 -> Co 2 so

```

**Bài 10** – nhập ma trận 3 x 3:

```

=== Bài 10 ===

Nhap so dong m: 3

Nhap so cot n: 3

a[0,0] = 1

a[0,1] = 2

a[0,2] = 3

a[1,0] = 4

a[1,1] = 5

a[1,2] = 6

a[2,0] = 7

a[2,1] = 8

a[2,2] = 9

Thu tu xoan oc: 1 2 3 6 9 8 7 4 5

```

**Bài 11** – nhập ma trận đơn vị cấp 3:

```

=== Bài 11 ===

Nhap cap ma tran vuong n: 3

a[0,0] = 1

a[0,1] = 0

a[0,2] = 0

a[1,0] = 0

a[1,1] = 1

a[1,2] = 0

a[2,0] = 0

a[2,1] = 0

a[2,2] = 1

Ma tran don vi: True

Ma tran doi xung: True

```

**Bài 12** – tạo bảng 4 x 4 với 3 quả mìn (vị trí mìn sinh ngẫu nhiên):

```

=== Bài 12 ===

Nhap so dong m: 4

Nhap so cot n: 4

Nhap so luong min: 3

Bang Minesweeper:

0 1 * 1

1 2 2 2

1 * 2 *

1 1 2 1

```

**Bài 13** – đảo ngược danh sách 4 phần tử:

```

=== Bài 13 ===

Nhap so luong phan tu cua danh sach: 4

Nhap phan tu thu 1: 10

Nhap phan tu thu 2: 20

Nhap phan tu thu 3: 30

Nhap phan tu thu 4: 40

Truoc khi dao: 10 20 30 40

Sau khi dao: 40 30 20 10

```

**Bài 14** – gộp 2 danh sách đã sắp xếp:

```

=== Bài 14 ===

Nhap danh sach sap xep 1:

Nhap so luong phan tu cua danh sach: 3

Nhap phan tu thu 1: 1

Nhap phan tu thu 2: 4

Nhap phan tu thu 3: 7

Nhap danh sach sap xep 2:

Nhap so luong phan tu cua danh sach: 3

Nhap phan tu thu 1: 2

Nhap phan tu thu 2: 5

Nhap phan tu thu 3: 9

Danh sach sau khi gop: 1 2 4 5 7 9

```

**Bài 15** – kiểm tra chu trình:

```

=== Bài 15 ===

Nhap so luong phan tu cua danh sach: 4

Nhap phan tu thu 1: 2

Nhap phan tu thu 2: 3

Nhap phan tu thu 3: 4

Nhap phan tu thu 4: 5

Ban co muon tao chu trinh khong? (1: Co, 0: Khong): 1

Danh sach co chua chu trinh

```

**Bài 16** – mô phỏng lịch sử duyệt web:

```

=== Bài 16 ===

--- LICH SU DUYET WEB ---

Trang hien tai: Chua co

1. Truy cap trang web moi

2. Back

3. Forward

0. Thoat Bai 16

Chon: 1

Nhap dia chi web: google.com

--- LICH SU DUYET WEB ---

Trang hien tai: google.com

1. Truy cap trang web moi

2. Back

3. Forward

0. Thoat Bai 16

Chon: 1

Nhap dia chi web: utehy.edu.vn

--- LICH SU DUYET WEB ---

Trang hien tai: utehy.edu.vn

1. Truy cap trang web moi

2. Back

3. Forward

0. Thoat Bai 16

Chon: 2

--- LICH SU DUYET WEB ---

Trang hien tai: google.com

1. Truy cap trang web moi

2. Back

3. Forward

0. Thoat Bai 16

Chon: 0

```

**Bài 17** – quản lý Playlist nhạc:

```

=== Bài 17 ===

--- PLAYLIST NHAC ---

Bai dang phat: Chua co

1. Them bai hat

2. Next

3. Previous

4. Xoa bai hat

0. Thoat Bai 17

Chon: 1

Nhap ten bai hat: Bai hat 1

--- PLAYLIST NHAC ---

Bai dang phat: Bai hat 1

1. Them bai hat

2. Next

3. Previous

4. Xoa bai hat

0. Thoat Bai 17

Chon: 1

Nhap ten bai hat: Bai hat 2

--- PLAYLIST NHAC ---

Bai dang phat: Bai hat 1

1. Them bai hat

2. Next

3. Previous

4. Xoa bai hat

0. Thoat Bai 17

Chon: 2

--- PLAYLIST NHAC ---

Bai dang phat: Bai hat 2

1. Them bai hat

2. Next

3. Previous

4. Xoa bai hat

0. Thoat Bai 17

Chon: 0

```

**Bài 18** – quản lý trạng thái đơn hàng:

```

=== Bài 18 ===

Nhap ma don hang: DH01

Don hang: DH01 - Trang thai: Cho xu ly

1. Chuyen trang thai tiep theo

2. Quay lai trang thai truoc

0. Thoat Bai 18

Chon: 1

Don hang: DH01 - Trang thai: Dang giao

1. Chuyen trang thai tiep theo

2. Quay lai trang thai truoc

0. Thoat Bai 18

Chon: 1

Don hang: DH01 - Trang thai: Hoan thanh

1. Chuyen trang thai tiep theo

2. Quay lai trang thai truoc

0. Thoat Bai 18

Chon: 0

```