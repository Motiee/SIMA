using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCServicesSima.Interfaces
{
   public interface ICollege
    {
        void Add(MVCServicesSima.Models.CollegeModel _college);
        void Update(MVCServicesSima.Models.CollegeModel _college);
        void Delete(MVCServicesSima.Models.CollegeModel _college);
        MVCServicesSima.Models.CollegeModel GetByAutoID(long AutoID);
        IEnumerable<MVCServicesSima.Models.CollegeModel> GetAll();
    }
}
