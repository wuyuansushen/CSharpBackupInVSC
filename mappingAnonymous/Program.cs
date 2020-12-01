using System;
using System.Collections.Generic;

namespace initializerObjCol
{
    public class Order
    {
        private List<OrderItem> items=new List<OrderItem>();
        public string OrderId{get;set;}
        public Customer Customer{get;set;}
        public List<OrderItem> Items{get{return items;}
        set{items=value;}}
    }
    public class Customer
    {
        public string Name{get;set;}
        public string Address{get;set;}
    }
    public class OrderItem
    {
        public string ItemId{get;set;}
        public int Quantity{get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var order=new Order{
                OrderId="xyz",
                Customer=new Customer {
                    Name="John",Address="UK"
                },
                Items={new OrderItem{ItemId="abcd123",Quantity=1},new OrderItem{ItemId="fghi456",Quantity=2}}
            };
            var flattenedItem=new{
                order.OrderId,
                ID=order.OrderId,
                order.Customer.Address,
                order.Customer.Name
            };
            Console.WriteLine(order.OrderId.GetHashCode());
            Console.WriteLine(flattenedItem.OrderId.GetHashCode());
            Console.WriteLine(flattenedItem.ID.GetHashCode());

            Console.WriteLine($"{order.OrderId} {flattenedItem.OrderId}");
        }
    }
}
