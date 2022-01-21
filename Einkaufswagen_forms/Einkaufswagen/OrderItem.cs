using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einkaufswagen
{
    public class OrderItem
    {
        string ProductName;
        int Amount;

        public OrderItem(string ProductName, int Amount)
        {
            this.ProductName = ProductName;
            this.Amount = Amount;
       
        }


        public String getProductName()
        {
            return this.ProductName;
        }
        public String getAmount()
        {
            return this.Amount.ToString();
        }

    }
}
