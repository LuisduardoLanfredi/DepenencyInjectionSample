using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Order o = new Order(new OrderItem());
			o.AddItem();

			Order o2 = new Order(new OrderItemExtra());
			o2.AddItem();

			Console.Read();
        }
    }
}