using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Model
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public DateTime JoinedDate { get; set; }
        public int PeriodOfContact { get; set; }
        [ForeignKey("Post")]
        public int PostID { get; set; }
        [ForeignKey("EmpType")]
        public int EmpTypeID { get; set; }
        [ForeignKey("Department")]
        public int DepID { get; set; }
        public double Sal { get; set; }
    }
}
