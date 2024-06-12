namespace Nhom6_QL_DiemTHPT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MALOP { get; set; }

        [Required]
        [StringLength(50)]
        public string TENLOP { get; set; }

        public int NIENKHOA { get; set; }

        [StringLength(10)]
        public string MAGVCN { get; set; }
        public int SOLUONG { get; set; }
        public int SOLUONGHOCSINH { get; set; }
    }
}
