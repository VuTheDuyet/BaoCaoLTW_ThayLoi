namespace VuTheDuyet.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanLoaiMonAn")]
    public partial class PhanLoaiMonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanLoaiMonAn()
        {
            MonAns = new HashSet<MonAn>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanLoaiMonAn { get; set; }

        [Required]
        [StringLength(200)]
        public string TenPhanLoaiMonAn { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
