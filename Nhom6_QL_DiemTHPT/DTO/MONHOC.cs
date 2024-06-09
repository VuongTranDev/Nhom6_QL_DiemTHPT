namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAMH { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMH { get; set; }
    }
}
