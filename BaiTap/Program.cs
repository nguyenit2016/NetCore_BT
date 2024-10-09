#region Bài tập buổi 02
// Bài tập 1
// Console.Write("Nhap vao so ngay: ");
// string? soNgayNhap = Console.ReadLine();
// int soNgay = int.Parse(soNgayNhap);
// int soTuan = soNgay / 7;
// int soNgayLe = soNgay % 7;
// Console.WriteLine($"So tuan: {soTuan}, so ngay le: {soNgayLe}");

// Bài tập 2
// Console.Write("Nhap vao gia tri don hang: ");
// string? giaTriDonHangNhap = Console.ReadLine();
// double giaTriDonHang = int.Parse(giaTriDonHangNhap);
// Console.Write("Nhap vao phan tram giam gia: ");
// string? phanTramGiamGiaNhap = Console.ReadLine();
// double phanTramGiamGia = int.Parse(phanTramGiamGiaNhap);
// double soTienGiamGia = (giaTriDonHang * phanTramGiamGia) / 100;
// double tongSoTienPhaiThanhToan = giaTriDonHang - soTienGiamGia;
// Console.WriteLine($"So tien giam gia: {soTienGiamGia}, tong so tien phai tra: {tongSoTienPhaiThanhToan}");

// Bài tập 3
// Console.Write("Nhap vao so phut: ");
// string soPhutNhap = Console.ReadLine();
// int soPhut = int.Parse(soPhutNhap);
// int soGioResult = soPhut / 60;
// int soPhutResult = soPhut % 60;
// Console.WriteLine($"So gio: {soGioResult}, so phut: {soPhutResult}");

// Bài tập 4
// Console.Write("Nhap vao so tien goc: ");
// string soTienNhap = Console.ReadLine();
// double soTien = double.Parse(soTienNhap);
// Console.Write("Nhap vao VAT: ");
// string vatNhap = Console.ReadLine();
// double vat = double.Parse(vatNhap);
// double tienThue = (soTien * vat) / 100;
// double tongSoTien = soTien + vat;
// Console.WriteLine($"Tong so tien: {tongSoTien}");

// Bài tập 5
// Console.Write("Nhap vao so tien USD: ");
// string soTienNhap = Console.ReadLine();
// double soTien = double.Parse(soTienNhap);
// Console.Write("Nhap vao ty gia chuyen doi USD sang VND: ");
// string tyGiaNhap = Console.ReadLine();
// double tyGia = double.Parse(tyGiaNhap);
// double tienVND = soTien * tyGia;
// Console.WriteLine($"{soTien}USD = {tienVND}VND");
#endregion

#region Bài tập buổi 08
//Mình hơi bận nên chưa làm kịp bài tập buổi 08, memtor chấm điểm mình sau nhé. Thanks

// Bài 1
// List<int> lst = new List<int>(){20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
// int sum = 0;
// foreach (int item in lst) {
//     sum += item;
// }
// Console.WriteLine(sum);

// Bài 2
// List<int> lst = new List<int>(){2, 7, 11, 15};
// int target = 9;
// for(int i = 0; i < lst.Count - 1; i++) {
//     for(int j = i + 1; j < lst.Count; j++) {
//         if (lst[i] + lst[j] == target) {
//             int iValue = lst[i];
//             int jValue = lst[j];
//             Console.WriteLine($"[{i}, {j}] (vi nums[{i}] + nums[{j}] = {iValue} + {jValue} = {target})");
//             break;
//         }
//     } 
// }

// Bài 3
// List<int> lst = new List<int>(){1, 1, 2, 2, 2, 3, 4, 4, 5};
// List<int> lstResult = new List<int>();
// foreach(int item in lst) {
//     if (!lstResult.Contains(item)) {
//         lstResult.Add(item);
//     }
// }
// Console.WriteLine(string.Join(",", lstResult));

// Bài 4

#endregion
