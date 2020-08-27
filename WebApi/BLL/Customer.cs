using System.Collections.Generic;
using System.Threading;

namespace WebApplication2 {
    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer() { }

        public Customer(dynamic pl) {
            Id = pl.ID;
            Name = pl.NAME;
        }

        public static IEnumerable<Customer> List() {
            List<Customer> lst = new List<Customer>();
            foreach (dynamic item in BLL.DB.Query("SELECT ID, NAME from customer", null)) {
                lst.Add(new Customer(item));
            }
            //Thread.Sleep(2000);
            return lst;
        }

        public static Customer Get(int id) {
            //Thread.Sleep(2000);
            return new Customer(BLL.DB.QueryFirst("SELECT ID, NAME from customer WHERE ID = :id", new { id }));
        }

    }
}