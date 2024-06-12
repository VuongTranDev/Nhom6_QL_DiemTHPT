namespace Nhom6_QL_DiemTHPT.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIANGDAY")]
    public partial class GIANGDAY
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MAGD { get; set; }

        [Required]
        [StringLength(10)]
        public string MAGV { get; set; }

        [Required]
        [StringLength(10)]
        public string MALOP { get; set; }
    }
}
