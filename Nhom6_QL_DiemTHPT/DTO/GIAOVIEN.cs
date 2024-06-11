namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVIEN")]
    public partial class GIAOVIEN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAGV { get; set; }

        [StringLength(50)]
        public string CHUYENMON { get; set; }
        [StringLength(50)]
        public string HOTEN { get; set; }
        [Required]
        [StringLength(10)]
        public string MAMH { get; set; }

        [Required]
        [StringLength(10)]
        public string MATT { get; set; }

        [StringLength(10)]
        public string MATK { get; set; }
    }
}
