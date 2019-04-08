using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCServicesSima.Models
{
  public class College
    {

     [Key]
     public int CollegeId { set; get; }

     public string CollegeTitle { set; get; }

     public int UniversityId { set; get; }

     public string Address { set; get; }

     public string Phone { set; get; }

     public string Email { set; get; }

     public string Website { set; get; }

     public int CityId { set; get; }

     public Boolean IsActive{ set; get; }
   
     public string Manager { set; get; }
     public int CenterId { set; get; }

     [ForeignKey("UniversityId")]
     public virtual University University { get; set; }

     [ForeignKey("CityId")]
     public virtual City City { get; set; }


    }
}
