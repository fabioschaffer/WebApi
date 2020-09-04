using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication2.Controllers {

    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase {

        [HttpGet]
        public IEnumerable<Customer> Get(string name, string city) {
            return Customer.List(name, city);
        }

        [HttpGet("{id}")]
        public Customer Get(int id) {
            return Customer.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] Customer value) {
            BLL.DB.InsertSQL("Customer", new { value.Name });
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value) {
            BLL.DB.UpdateSQL("Customer", new { id, value.Name }, "id");
        }

        [HttpDelete("{id}")]
        public void Delete(int id) {
            BLL.DB.Execute("DELETE Customer WHERE id = :id", new { id });
        }
    }
}