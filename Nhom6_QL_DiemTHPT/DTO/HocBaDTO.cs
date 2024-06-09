using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_QL_DiemTHPT.DTO
{
    public class HocBaDTO
    {
        public int ID { get ; set ; }
        public string MAHB { get; set; }
        public string MAHS { get; set; }
        public string XEPLOAI { get; set; }
        public string HANHKIEM { get ; set ; }
        public float DIEMHK1 { get; set; }
        public float DIEMHK2 { get; set; }
        public float DIEMTONG { get; set; }

        public HocBaDTO()
        {

        }
    }
}
