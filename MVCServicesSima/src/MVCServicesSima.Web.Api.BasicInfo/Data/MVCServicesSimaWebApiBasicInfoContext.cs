using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCServicesSima.Models;

namespace MVCServicesSima.Web.Api.BasicInfo.Models
{
    public class MVCServicesSimaWebApiBasicInfoContext : DbContext
    {
        public MVCServicesSimaWebApiBasicInfoContext (DbContextOptions<MVCServicesSimaWebApiBasicInfoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCServicesSima.Models.City> City { get; set; }

        public DbSet<MVCServicesSima.Models.University> University { get; set; }

        public DbSet<MVCServicesSima.Models.Center> Center { get; set; }

        public DbSet<MVCServicesSima.Models.College> College { get; set; }

        public DbSet<MVCServicesSima.Models.CollegeGroup> CollegeGroup { get; set; }

        public DbSet<MVCServicesSima.Models.Major> Major { get; set; }
    }
}
