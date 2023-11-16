namespace VuTheDuyet.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        [StringLength(100)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(100)]
        public string HoVaTen { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Quyen { get; set; }
    }
}
