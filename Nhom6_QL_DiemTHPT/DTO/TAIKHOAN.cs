namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string MATK { get; set; }

        [StringLength(20)]
        public string TENTK { get; set; }

        [StringLength(20)]
        public string MATKHAU { get; set; }

        [StringLength(20)]
        public string LOAITK { get; set; }
    }
}
