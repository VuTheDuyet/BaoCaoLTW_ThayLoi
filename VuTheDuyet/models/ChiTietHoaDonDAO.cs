using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuTheDuyet.models
{
    internal class ChiTietHoaDonDAO
    {
        private QLNHConnext db;

            public ChiTietHoaDonDAO()
            {
                db = new QLNHConnext(); // Thay thế QLNHConnext bằng tên của context của bạn
            }

            public List<ChiTietHoaDon> getList()
            {
                try
                {
                    return db.ChiTietHoaDons.ToList();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }

            public int getCount()
            {
                try
                {
                    return db.ChiTietHoaDons.Count();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                    return -1;
                }
            }

            public void add(ChiTietHoaDon chiTietHoaDon)
            {
                try
                {
                    db.ChiTietHoaDons.Add(chiTietHoaDon);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                }
            }

            public void update(ChiTietHoaDon chiTietHoaDon)
            {
                try
                {
                    db.Entry(chiTietHoaDon).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                }
            }

            public void delete(int maChiTietHoaDon)
            {
                try
                {
                    ChiTietHoaDon chiTietHoaDon = db.ChiTietHoaDons.FirstOrDefault(cthd => cthd.ID == maChiTietHoaDon);

                    if (chiTietHoaDon != null)
                    {
                        db.ChiTietHoaDons.Remove(chiTietHoaDon);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                }
            }

            public ChiTietHoaDon getRow(int maChiTietHoaDon)
            {
                try
                {
                    return db.ChiTietHoaDons.FirstOrDefault(cthd => cthd.MaHoaDon == maChiTietHoaDon);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        public void seachanhinput(int maDonHangCanTim)
        {
           
            // Tìm đối tượng HoaDon từ cơ sở dữ liệu dựa trên mã đơn hàng
            HoaDon hoaDon = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == maDonHangCanTim);

            if (hoaDon != null)
            {
                // Tìm tất cả các bản ghi ChiTietHoaDon liên quan dựa trên mã đơn hàng
                var relatedChiTietHoaDonRecords = db.ChiTietHoaDons.Where(ct => ct.MaHoaDon == hoaDon.MaHoaDon);

                // Kiểm tra và xuất ra thông tin các bản ghi ChiTietHoaDon liên quan
                if (relatedChiTietHoaDonRecords.Any())
                {
                    foreach (var chiTietHoaDon in relatedChiTietHoaDonRecords)
                    {
                        // Xuất ra thông tin ChiTietHoaDon (ví dụ: Console.WriteLine, MessageBox.Show, ...)
                        Console.WriteLine($"Mã ChiTietHoaDon: {chiTietHoaDon.MaMonAn}, Số lượng: {chiTietHoaDon.SoLuong}, ...");
                    }
                }
                else
                {
                    // Thông báo khi không tìm thấy bản ghi ChiTietHoaDon liên quan
                    Console.WriteLine("Không có bản ghi ChiTietHoaDon liên quan.");
                }
            }
            else
            {
                // Thông báo khi không tìm thấy HoaDon
                Console.WriteLine("Không tìm thấy HoaDon.");
            }
        }
        

    }
}
