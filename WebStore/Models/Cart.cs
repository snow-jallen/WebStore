using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<CartItem>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Started { get; set; }
        public IList<CartItem> Items { get; set; }
    }
}
