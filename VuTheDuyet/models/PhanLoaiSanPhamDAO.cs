using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuTheDuyet.models
{
    internal class PhanLoaiSanPhamDAO
    {
        QLNHConnext db = new QLNHConnext();

        public List<PhanLoaiMonAn> getList()
        {
            List<PhanLoaiMonAn> list = db.PhanLoaiMonAns.ToList();
            return list;
        }
        public int getCount()
        {
            return db.PhanLoaiMonAns.Count();
        }
        public void add(PhanLoaiMonAn PhanLoaiMonAn)
        {
            db.PhanLoaiMonAns.Add(PhanLoaiMonAn);
            db.SaveChanges();
        }
        public void update(PhanLoaiMonAn updatedPhanLoaiMonAn)
{
    // Tìm bản ghi cần cập nhật trong cơ sở dữ liệu
    PhanLoaiMonAn existingPhanLoaiMonAn = db.PhanLoaiMonAns.Find(updatedPhanLoaiMonAn.MaPhanLoaiMonAn);

    if (existingPhanLoaiMonAn != null)
    {
        // Cập nhật thuộc tính của bản ghi hiện tại với thông tin từ bản ghi được cung cấp
        db.Entry(existingPhanLoaiMonAn).CurrentValues.SetValues(updatedPhanLoaiMonAn);

        // Lưu các thay đổi vào cơ sở dữ liệu
        db.SaveChanges();

        // Cập nhật lại MaPhanLoaiMonAn trong bảng MonAn
        var relatedMonAnRecords = db.MonAns
            .Where(ma => ma.MaPhanLoaiMonAn == updatedPhanLoaiMonAn.MaPhanLoaiMonAn)
            .ToList();

        foreach (var monAnRecord in relatedMonAnRecords)
        {
            // Cập nhật lại MaPhanLoaiMonAn trong bảng MonAn
            monAnRecord.MaPhanLoaiMonAn = updatedPhanLoaiMonAn.MaPhanLoaiMonAn;

            // Đặt trạng thái của bản ghi MonAn là EntityState.Modified
            db.Entry(monAnRecord).State = EntityState.Modified;
        }

        // Lưu các thay đổi trong bảng MonAn vào cơ sở dữ liệu
        db.SaveChanges();
    }
}


        public void delete(int monAn)
        {
            PhanLoaiMonAn monan = db.PhanLoaiMonAns.FirstOrDefault(tv => tv.MaPhanLoaiMonAn == monAn);
            if (monan != null)
            {
                // Tìm và xóa các bản ghi MonAn liên quan
                var relatedMonAnRecords = db.MonAns.Where(ma => ma.MaPhanLoaiMonAn == monAn);
                db.MonAns.RemoveRange(relatedMonAnRecords);

                // Xóa bản ghi PhanLoaiMonAn
                db.PhanLoaiMonAns.Remove(monan);

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SaveChanges();
            }
          //  db.PhanLoaiMonAns.Remove(monan);
           // db.SaveChanges();
        }
        public PhanLoaiMonAn GetRow(int maMA)
        {
            //  string sql = "SELECT PhanLoaiMonAn.MaPhanLoaiMonAn, PhanLoaiMonAn.TenPhanLoaiMonAn, PhanLoaiMonAn.Gia ,PhanLoaiMonAn.MaPhanLoaiPhanLoaiMonAn ";
            // sql += "FROM PhanLoaiMonAn INNER JOIN PhanLoaiPhanLoaiMonAn.MaPhanLoaiPhanLoaiMonAn=PhanLoaiMonAn.MaPhanLoaiPhanLoaiMonAn WHERE PhanLoaiMonAn.MaPhanLoaiPhanLoaiMonAn='" + maMA+"'";
            //  HMACMD5 
            // Sử dụng LINQ để kiểm tra xem có bản ghi nào có Username tương ứng không
            PhanLoaiMonAn phanLoaiMonAn = db.PhanLoaiMonAns.FirstOrDefault(tv => tv.MaPhanLoaiMonAn == maMA);

            // Trả về đối tượng ThanhVien hoặc null nếu không tìm thấy
            return phanLoaiMonAn;
        }
    }
}
