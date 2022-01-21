using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warenkorb_forms
{
    internal class OrderItem
    {
        public List<OrderItem> productList = new List<OrderItem>();

        string productName;
        int quantity;

        public OrderItem(string ProductName, int quantity)
        {
            this.productName = ProductName;
            this.quantity = quantity;
        }

        private void AddToList()
        {
            
        }
    }
}
