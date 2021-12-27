using Assignment.Models;
using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CompanyContext())
            {
                var scheme = new Schemes()
                {
                    OrderAmount = 1000,
                    DiscountAmount = 100
                };
                context.Schemes.Add(scheme);
                context.SaveChanges();

                var plant = new Plant()
                {
                    PlantHead = "Chitrank ",
                    PlantName = "Cars"
                };

                context.Plants.Add(plant);

                var cust = new Customer()
                {
                    CustomerName = "Parul",
                    PhoneNo = "7383135287"
                };
                context.Customers.Add(cust);

                var toy = new Toy()
                {
                    ToyName = "Car1",
                    Price = "500",
                    PlantId = 2

                };
                context.Toys.Add(toy);

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    CustomerId = 2,
                    ToyId = 4,
                    TotalAmount = 500,
                    PaymentType = "Cash",
                    TotalAmountPaid = 500
                };
                context.Orders.Add(order);

                context.SaveChanges();
            }

        }
    }
}
