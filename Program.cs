using System.Threading.Channels;
using ef_core.Data;
using ef_core.Models;

using DataContext context  = new DataContext();

// Product product = new()
// {
//     Name = "Iphone 12",
//     Price = 1100,
// };
//
// Customer customer = new Customer()
// {
//     Address = "Luisental 29",
//     Phone = "874858883",
//     FirstName = "Siani Lucien",
//     LastName = "Leroy",
//     Orders = new List<Order>()
//     {
//         new Order(),
//         new Order(),
//     }
// };
// context.Add(product);
// context.Add(customer);
// context.SaveChanges();

var products = context.Products.
                                            Where(p => p.
                                            Price < 10000).
                                            OrderBy( p => p.Name);
                                            
                                            foreach(var item in products)
                                                Console.WriteLine(item.Name);