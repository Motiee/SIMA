using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCServicesSima.Models
{
   public class Major
    {
        [Key]
        public int MajorId { set; get; }

        public string MajorTitle { set; get; }

        public int GroupId { set; get; }

        [ForeignKey("GroupId")]
        public virtual CollegeGroup CollegeGroup { set; get; }

        public int CollegeId { set; get; }

        [ForeignKey("CollegeId")]
        public virtual College College { set; get; }

        public int UniversityId { set; get; }

        [ForeignKey("UniversityId")]
        public virtual University University { set; get; }
        public string Address { set; get; }

        public string Phone { set; get; }

        public string Email { set; get; }

        public string Website { set; get; }

        public int CityId { set; get; }

        [ForeignKey("CityId")]
        public virtual City City { set; get; }

        public Boolean IsActive { set; get; }
       
        public string Manager { set; get; }

        public int CenterId { set; get; }

        [ForeignKey("CenterId")]
        public virtual Center Center { set; get; }
    }
}
