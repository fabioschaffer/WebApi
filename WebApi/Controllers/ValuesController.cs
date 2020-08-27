using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication2.Controllers {

    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Customer> Get() {
            return Customer.List();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Customer Get(int id) {
            return Customer.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Customer value) {
            //IEnumerable<dynamic>  list = BLL.DB.Query("SELECT * from customer", null);
            //list.GetHashCode();
            BLL.DB.InsertSQL("Customer", new { value.Name });
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value) {
            BLL.DB.UpdateSQL("Customer", new { id, value.Name }, "id");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            BLL.DB.Execute("DELETE Customer WHERE id = :id", new { id });
        }
    }
}
