namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCKY")]
    public partial class HOCKY
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHK { get; set; }

        [StringLength(100)]
        public string TENHK { get; set; }

        public int? NAMHOC { get; set; }
    }
}
