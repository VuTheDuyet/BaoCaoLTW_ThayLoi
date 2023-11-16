using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuTheDuyet.models
{
    internal class HoaDonDAO
    {
        QLNHConnext db = new QLNHConnext();

        public List<HoaDon> getList()
        {
            List<HoaDon> list = db.HoaDons.ToList();
            return list;
        }

        public int getCount()
        {
            return db.HoaDons.Count();
        }

        public void add(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
        }

        public void update(HoaDon hoaDon)
        {
            db.Entry(hoaDon).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void delete(int maHoaDon)
        {
            try
            {
                HoaDon hoaDon = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);

                if (hoaDon != null)
                {
                    // Xoá chi tiết hóa đơn trước nếu có
                    XoaChiTietHoaDonTheoHoaDon(maHoaDon);

                    db.HoaDons.Remove(hoaDon);
                    db.SaveChanges();
                }
                else
                {
                    // Hiển thị thông báo: Mã đơn hàng không tồn tại
                    Console.WriteLine("Mã đơn hàng không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo lỗi
                Console.WriteLine("Lỗi khi xoá đơn hàng: " + ex.Message);
            }
        }

        // Hàm xoá chi tiết hóa đơn theo đơn hàng
        private void XoaChiTietHoaDonTheoHoaDon(int maHoaDon)
        {
            var chiTietHoaDons = db.ChiTietHoaDons.Where(cthd => cthd.MaHoaDon == maHoaDon).ToList();

            if (chiTietHoaDons != null && chiTietHoaDons.Count > 0)
            {
                db.ChiTietHoaDons.RemoveRange(chiTietHoaDons);
                db.SaveChanges();
            }
        }

        public HoaDon getRow(int maHoaDon)
        {
            HoaDon hoaDon = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == maHoaDon);
            return hoaDon;
        }
    }
}
