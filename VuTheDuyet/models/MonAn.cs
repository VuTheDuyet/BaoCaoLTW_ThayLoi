namespace VuTheDuyet.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [Key]
        [StringLength(10)]
        public string MaMonAn { get; set; }

        [Required]
        [StringLength(200)]
        public string TenMonAn { get; set; }

        public double Gia { get; set; }

        public int MaPhanLoaiMonAn { get; set; }

        public virtual PhanLoaiMonAn PhanLoaiMonAn { get; set; }
    }
}
