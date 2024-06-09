namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINCANHAN")]
    public partial class THONGTINCANHAN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MATT { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }
    }
}
