namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHS { get; set; }

        [StringLength(20)]
        public string DANTOC { get; set; }

        [StringLength(20)]
        public string TONGIAO { get; set; }

        [StringLength(500)]
        public string DIACHI { get; set; }

        [Required]
        [StringLength(10)]
        public string MATRUONG { get; set; }

        [Required]
        [StringLength(10)]
        public string MATT { get; set; }

        [StringLength(10)]
        public string MATK { get; set; }
    }
}
