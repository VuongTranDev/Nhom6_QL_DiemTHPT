namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCBA")]
    public partial class HOCBA
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHB { get; set; }

        [StringLength(10)]
        public string MAHS { get; set; }

        [StringLength(20)]
        public string XEPLOAI { get; set; }

        [StringLength(20)]
        public string HANHKIEM { get; set; }

        public double? DIEMHK1 { get; set; }

        public double? DIEMHK2 { get; set; }

        public double? DIEMTONG { get; set; }
    }
}
