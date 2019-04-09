using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCServicesSima.Models
{
    class Prerequisite
    {
        [Key]
       public int PrerequisiteId { set; get; }

       public int LessonId { set; get; }

       public Boolean IsAttendant { set; get; }
       
       public string Describe { set; get; }
    }
}
