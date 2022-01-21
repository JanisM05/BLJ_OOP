using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddProduct_Form af = new AddProduct_Form();

            foreach (OrderItem product in af.productList)
            {
                lb_products.Text += product.ToString();
                lb_products.Text += "\n";

                MessageBox.Show(product.ToString());
            }
        }

        private void lb_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
