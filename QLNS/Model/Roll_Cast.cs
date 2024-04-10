using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Model
{
    public class Roll_Cast
    {
        [Key]
        [ForeignKey("Employee")]
        public int EmpID { get; set; }
        public int BreakDay { get; set; }
        public int AddDay { get; set; } 
        public int Total { get; set; }
    }
}
