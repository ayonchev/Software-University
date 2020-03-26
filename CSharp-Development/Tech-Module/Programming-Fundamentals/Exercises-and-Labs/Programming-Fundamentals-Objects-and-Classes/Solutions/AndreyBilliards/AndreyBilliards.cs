using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyBilliards
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductAndQuantity { get; set; }
        public double Bill { get; set; }
    }

    class AndreyBilliards
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> priceList = new Dictionary<string, double>();
            List<Customer> customerList = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                string[] inputPriceList = Console.ReadLine().Split('-');
                string product = inputPriceList[0];
                double price = double.Parse(inputPriceList[1]);

                if (!priceList.ContainsKey(product))
                {
                    priceList.Add(product, price);
                }
                else
                {
                    priceList[product] = price;
                }
            }

            while (true)
            {
                string[] inputCustomerList = Console.ReadLine().
                    Split(new char[] { '-', ',' },
                    StringSplitOptions.
                    RemoveEmptyEntries);

                if (string.Join(" ", inputCustomerList) == "end of clients")
                {
                    break;
                }
                else
                {
                    string customerName = inputCustomerList[0];
                    string orderedProduct = inputCustomerList[1];
                    int quantityOfProduct = int.Parse(inputCustomerList[2]);

                    if (priceList.ContainsKey(orderedProduct))
                    {
                        if (customerList.Count > 0)
                        {
                            for (int i = 0; i < customerList.Count; i++)
                            {
                                if (customerList[i].Name == customerName)
                                {
                                    customerList[i].ProductAndQuantity.Add(orderedProduct, quantityOfProduct);
                                    customerList[i].Bill += quantityOfProduct * priceList[orderedProduct];
                                }
                            }
                        }
                        else
                        {
                            Customer currentCustomer = new Customer()
                            {
                                Name = customerName,
                                ProductAndQuantity = new Dictionary<string, int>()
                            };
                            currentCustomer.ProductAndQuantity.Add(orderedProduct, quantityOfProduct);
                            currentCustomer.Bill = quantityOfProduct * priceList[orderedProduct];
                            customerList.Add(currentCustomer);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            double totalBill = 0;
            foreach (var customer in customerList.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);
                Dictionary<string, int> customersOrder = customer.ProductAndQuantity;

                foreach (var person in customersOrder)
                {
                    Console.WriteLine($"-- {person.Key} - {person.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
