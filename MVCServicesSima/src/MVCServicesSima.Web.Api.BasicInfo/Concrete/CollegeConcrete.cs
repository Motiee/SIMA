using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCServicesSima.Models;

namespace MVCServicesSima.Web.Api.BasicInfo.Concrete
{
    public class CollegeConcrete : MVCServicesSima.Interfaces.ICollege

    {
        public void Add(CollegeModel _college)
        {
            throw new NotImplementedException();
        }

        public void Delete(CollegeModel _college)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CollegeModel> GetAll()
        {
            return null;
            //throw new NotImplementedException();
        }

        public CollegeModel GetByAutoID(long AutoID)
        {
            throw new NotImplementedException();
        }

        public void Update(CollegeModel _college)
        {
            throw new NotImplementedException();
        }
    }
}
