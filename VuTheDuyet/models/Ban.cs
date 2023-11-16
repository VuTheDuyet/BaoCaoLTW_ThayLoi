namespace VuTheDuyet.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ban")]
    public partial class Ban
    {
        [Key]
        [StringLength(100)]
        public string MaBan { get; set; }

        [Required]
        [StringLength(100)]
        public string TenBan { get; set; }
    }
}
