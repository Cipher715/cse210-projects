using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Online Ordering!");
        Console.WriteLine("Here are some orders:");
        Console.WriteLine();
        Address address1 = new Address("Kulanui 229", "Laie", "Hawaii", "USA");
        Address address2 = new Address("Kitano 7-4", "Mitaka", "Tokyo", "Japan");
        Customer customer1 = new Customer("Jhon Smith", address1);
        Customer customer2 = new Customer("Atsishi Karino", address2);
        Product product1 = new Product("iPhone", 15, 899.99, 2);
        Product product2 = new Product("Galaxy S4", 5, 50, 1);
        Product product3 = new Product("Logicool Mouse", 21, 30, 1);
        Product product4 = new Product("Acer Monitor", 32, 40.28, 2);
        Product product5 = new Product("Tesla ModelX", 1, 106630, 1);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        List<Order> orders = new List<Order>{order1, order2};
        foreach(Order order in orders){
            Console.WriteLine("--------------------------");
            List<string> packing = order.GetPackingLabel();
            List<string> shipping = order.GetShippingLabel();
            Console.WriteLine("Order Includes:");
            foreach(string label in packing){
                Console.WriteLine(label);
            }
            Console.WriteLine();
            Console.WriteLine("Shipping To:");
            foreach(string label in shipping){
                Console.WriteLine(label);
            }
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.GetTotalPrice()}");
        }
    }   
}