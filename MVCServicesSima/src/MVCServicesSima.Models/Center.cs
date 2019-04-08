﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCServicesSima.Models
{
  public class Center
    {
        [Key]
        public int CenterId { get; set; }

        public string CenterTitle { get; set; }

        public int UniversityId { get; set; }

        public string Address { get; set; }

        public int CityId { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        [ForeignKey("UniversityId")]
        public virtual University University { get; set; }

    }
}
