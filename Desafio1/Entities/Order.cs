using Desafio1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderList { get; set; } = new List<OrderItem>();
        public Order()
        {
        }
        public Order(DateTime date, OrderStatus orderStatus, Client client)
        {
            Date = date;
            OrderStatus = orderStatus;
            Client = new Client(client.Name, client.Email, client.BirthDate);
        }
        public void AddItem(OrderItem orderItem)
        {
            OrderList.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderList.Remove(orderItem);
        }
        public double Total ()
        {
            double sum = 0;
            foreach (OrderItem orders in OrderList)
            {
                sum += orders.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus.ToString());
            Console.WriteLine(Client.ToString());
            foreach (OrderItem item in OrderList)
            {
                Console.WriteLine(item.ToString());
            }
            sb.AppendLine("Total: " + Total());
            return sb.ToString();
        }
    }
}
