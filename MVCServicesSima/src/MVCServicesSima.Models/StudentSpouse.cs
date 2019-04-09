using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCServicesSima.Models
{
   public class StudentSpouse
    {
        [Key]
       public long SpouseId { set; get; }

       public long StudentId { set; get; }
      

      public string FirstName { set; get; }

      public string LastName { set; get; }

      public string NationalCode { set; get; }

      public string FatherName { set; get; }

      public int IssueCityId { set; get; }

      [ForeignKey("IssueCityId")]
      public virtual City IssueCity { set; get; }
      public string Job { set; get; }

      public string IdCardNo { set; get; }

      public DateTime BrithDate { set; get; }
    }
}
