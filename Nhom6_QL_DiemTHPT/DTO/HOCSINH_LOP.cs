namespace Nhom6_QL_DiemTHPT.ASD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOCSINH_LOP
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAHS { get; set; }

        [StringLength(10)]
        public string MALOP { get; set; }

        [StringLength(30)]
        public string TINHTRANG { get; set; }
    }
}
