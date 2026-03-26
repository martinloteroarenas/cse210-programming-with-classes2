using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("oaxaca-16av", "Ciudad Victoria", "Tamaulipas", "mexico");
        Customer customer1 = new Customer("Juan Pelaez", address1);
        Order order1 = new Order(customer1);
        Product product1Order1 = new Product("Large socks", "9484-GK", 8, 2);
        Product product2Order1 = new Product("sunglasses", "4353-RT", 12, 4);
        order1.AddProducts(product1Order1);
        order1.AddProducts(product2Order1);

        Address address2 = new Address("E 500N- N400 E", "Provo", "Utah", "USA");
        Customer customer2 = new Customer("Jack Thompson", address2);
        Order order2 = new Order(customer2);
        Product product1Order2 = new Product("Black Shoes", "5449-LB", 42, 1);
        Product product2Order2 = new Product("Large Pillow", "2501-WO", 14, 2);
        order2.AddProducts(product1Order2);
        order2.AddProducts(product2Order2);

        List<Order> _orders = new List<Order>();
        _orders.Add(order1);
        _orders.Add(order2);

        foreach(Order order in _orders)
        {
            Console.WriteLine(order.GetDisplayPackingLabel());
            Console.WriteLine(order.GetDisplayShippingLabel());
            Console.WriteLine($"Total cost + shipping = {order.OrderTotalCost()} $");
            Console.WriteLine("-------------------------------------------------");
        }
    }
}