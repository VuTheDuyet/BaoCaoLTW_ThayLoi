using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuTheDuyet.models
{
    internal class ThanhVienDAO
    {
        QLNHConnext db = new QLNHConnext();

        public List<ThanhVien> getList()
        {
            List<ThanhVien> list = db.ThanhViens.ToList();
            return list;
        }
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        public ThanhVien getRow(string username)
        {
            // Sử dụng LINQ để kiểm tra xem có bản ghi nào có Username tương ứng không
            ThanhVien thanhVien = db.ThanhViens.FirstOrDefault(tv => tv.TenDangNhap == username);

            // Trả về đối tượng ThanhVien hoặc null nếu không tìm thấy
            return thanhVien;
        }
        public void update(ThanhVien tv)
        {
            db.Entry(tv).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void add(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void delete(string monAn)
        {
            ThanhVien monan = db.ThanhViens.FirstOrDefault(tv => tv.SDT == monAn);
            db.ThanhViens.Remove(monan);
            db.SaveChanges();
        }
    }
}
