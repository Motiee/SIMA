using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCServicesSima.Models
{
  public  class City
    {
        [Key]
        public int AreaId { get; set; }
        
        public string AreaTitle { get; set; }

        public string city { get; set; }

        public string ProvinceTitle { get; set; }

        public int ProvinceCode { get; set; }
    }
}
