namespace VuTheDuyet.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? MaHoaDon { get; set; }

        [StringLength(10)]
        public string MaMonAn { get; set; }

        public int? SoLuong { get; set; }

        public decimal? GiaTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
