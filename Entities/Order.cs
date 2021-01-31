using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class Order
    {
        public int Id { get; set; }
        public int GamerId { get; set; }
        public int GameId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public double OrderPrice { get; set; }
        public int NumberOf { get; set; }
    }
}
