using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCServicesSima.Interfaces
{
  public interface ICity
    {
        void Add(MVCServicesSima.Models.CityModel _City);
        void Update(MVCServicesSima.Models.CityModel _City);
        void Delete(MVCServicesSima.Models.CityModel _City);
        MVCServicesSima.Models.CityModel GetByAreaId(int AreaId);
        IEnumerable<MVCServicesSima.Models.CityModel> GetAll();
    }
}
