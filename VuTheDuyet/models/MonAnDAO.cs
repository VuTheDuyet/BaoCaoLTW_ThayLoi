using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VuTheDuyet.models
{
    internal class MonAnDAO
    {
        QLNHConnext db = new QLNHConnext();

        public List<MonAn> getList()
        {
            List<MonAn > list = db.MonAns.ToList();
            return list;
        }
        public int getCount()
        {
            return db.MonAns.Count();
        }
        public void add(MonAn monAn)
        {
            db.MonAns.Add(monAn);
            db.SaveChanges();
        }
        public void update(MonAn monAn)
        {
            db.Entry(monAn).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void delete(string monAn)
        {
            MonAn monan = db.MonAns.FirstOrDefault(tv => tv.MaMonAn == monAn);
            db.MonAns.Remove(monan);
            db.SaveChanges();
        }
        public MonAn GetRow(string maMA)
        {
            //  string sql = "SELECT MonAn.MaMonAn, MonAn.TenMonAn, MonAn.Gia ,MonAn.MaPhanLoaiMonAn ";
            // sql += "FROM MonAn INNER JOIN PhanLoaiMonAn.MaPhanLoaiMonAn=MonAn.MaPhanLoaiMonAn WHERE MonAn.MaPhanLoaiMonAn='" + maMA+"'";
            //  HMACMD5 
            // Sử dụng LINQ để kiểm tra xem có bản ghi nào có Username tương ứng không
            MonAn monan = db.MonAns.FirstOrDefault(tv => tv.MaMonAn == maMA);

            // Trả về đối tượng ThanhVien hoặc null nếu không tìm thấy
            return monan;
        }
    }
}
