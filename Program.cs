using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Console_application_work
{

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

    } class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

    }
    class Program
    {

        public async Task method()
        {

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Alice" },
                new Customer { Id = 2, Name = "Bob" },
                new Customer { Id = 3, Name = "John" }
            };

            var orders = new List<Order>
            {
                new Order { OrderId = 101, CustomerId = 1 },
                new Order { OrderId = 102, CustomerId = 2 },
                new Order { OrderId = 103, CustomerId = 1 },
                new Order { OrderId = 104, CustomerId = 3 }
            };


            var joinCom = (from k in customers join L in orders on k.Id equals L.CustomerId select new { k.Id, k.Name, L.CustomerId }).ToList();


            await Task.Run(() =>
            {
                for (int i = 0; i < joinCom.Count; i++)

                {
                    Console.WriteLine(joinCom[i]);
                }
            });     
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.method();


                Console.Read();
        }
    }
}
