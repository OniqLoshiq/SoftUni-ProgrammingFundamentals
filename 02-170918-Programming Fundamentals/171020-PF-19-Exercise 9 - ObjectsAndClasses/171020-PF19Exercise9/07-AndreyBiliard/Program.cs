using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AndreyBiliard
{
    class Clients
    {
        public string Name { get; set; }
        public Dictionary<string, int> Bill { get; set; }
        public decimal TotalBill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> entities = GetEntitiesAndPrices(n);

            string inputClients = Console.ReadLine();

            List<Clients> allClients = new List<Clients>();

            while (inputClients != "end of clients")
            {
                string[] input = inputClients.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                string entity = input[1];
                int quantity = int.Parse(input[2]);

                if (entities.ContainsKey(entity))
                {
                    if (allClients.Any(x => x.Name == name))
                    {
                        if (allClients.Where((x => x.Name == name)).Any(x => x.Bill.ContainsKey(entity)))
                        {
                            var cust = allClients.Where(x => x.Name == name).Single(x => x.Bill.ContainsKey(entity));
                            cust.Bill[entity] += quantity;
                            cust.TotalBill += quantity * entities[entity];
                        }
                        else
                        {
                            var cust = allClients.Where(x => x.Name == name).First();
                            cust.Bill.Add(entity, quantity);
                            cust.TotalBill += quantity * entities[entity];
                        }
                    }
                    else
                    {
                        Clients client = new Clients();
                        client.Bill = new Dictionary<string, int>();
                        client.Name = name;
                        client.Bill[entity] = quantity;
                        client.TotalBill = quantity * entities[entity];
                        allClients.Add(client);
                    }
                }

                inputClients = Console.ReadLine();
            }

            decimal allClientsTotalBills = 0.0M;

            foreach (var customer in allClients.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.Bill)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);

                }
                Console.WriteLine("Bill: {0:f2}", customer.TotalBill);
                allClientsTotalBills += customer.TotalBill;
            }
            Console.WriteLine("Total bill: {0:f2}", allClientsTotalBills);
        }

        private static Dictionary<string, decimal> GetEntitiesAndPrices(int n)
        {
            var entities = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] inputEntity = Console.ReadLine().Split('-');


                if (!entities.ContainsKey(inputEntity[0]))
                {
                    entities[inputEntity[0]] = 0.0M;
                }
                entities[inputEntity[0]] = decimal.Parse(inputEntity[1]);
            }

            return entities;
        }
    }
}
