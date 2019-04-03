using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCServicesSima.Web.Api.BasicInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private MVCServicesSima.Interfaces.ICollege _College;

        public CollegeController(MVCServicesSima.Interfaces.ICollege ICollege)
        {
            _College = ICollege;
        }

        // GET: api/College
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _College.GetAll();
            return new string[] { "value1", "value2" };
        }

        // GET: api/College/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
           
            return "value";
        }

        // POST: api/College
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/College/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
