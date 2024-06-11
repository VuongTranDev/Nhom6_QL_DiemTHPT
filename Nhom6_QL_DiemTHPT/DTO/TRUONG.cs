namespace Nhom6_QL_DiemTHPT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRUONG")]
    public partial class TRUONG
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MATRUONG { get; set; }

        [Required]
        [StringLength(100)]
        public string TENTRUONG { get; set; }

        [Required]
        [StringLength(255)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string MATK { get; set; }
    }
}
