using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class OrderManager : IOrderService
    {
        public void Order(Order order)
        {
            Console.WriteLine("Order has received :  "+ order.Id +" "+  order.GamerId + " " + order.GameId + " " + order.DateOfOrder + " " +  order.NumberOf + " " + order.OrderPrice );
        }
    }
}
