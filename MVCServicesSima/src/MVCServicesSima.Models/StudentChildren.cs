using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCServicesSima.Models
{
    public class StudentChildren
    {
        [Key]
        public long ChildId { set; get; }
        public long StudentId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string NationalCode { set; get; }

        public int IssueCityId { set; get; }

        [ForeignKey("IssueCityId")]
        public virtual City IssueCity { get; set; }

        public string IdCardNo { get; set; }

        public DateTime BrithDate { get; set; }
    }
}
