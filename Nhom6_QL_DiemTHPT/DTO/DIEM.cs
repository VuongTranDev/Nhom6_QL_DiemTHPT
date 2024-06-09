namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEM")]
    public partial class DIEM
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHS { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMH { get; set; }

        [StringLength(10)]
        public string MALOP { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHK { get; set; }

        public double? DIEMHS1 { get; set; }

        public double? DIEMHS2 { get; set; }

        public double? DIEMTHI { get; set; }

        public double? DIEMTB { get; set; }
    }
}
