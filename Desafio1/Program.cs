using Desafio1.Entities;
using Desafio1.Entities.Enums;
using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date: ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered)");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtdOrders = int.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirthDate);
            DateTime dateMoment = DateTime.Now;
            Order order = new Order(dateMoment, status, client);

            for(int i=1; i <= qtdOrders; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(qtd, productPrice, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY:");
            order.ToString();
        }
    }
}
