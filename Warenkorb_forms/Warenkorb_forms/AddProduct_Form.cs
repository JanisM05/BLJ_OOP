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
    internal partial class AddProduct_Form : Form
    {

        public AddProduct_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_gotoShoppingCart_Click(object sender, EventArgs e)
        {
            Form1 sh = new Form1();
            sh.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string productname = txt_productName.Text;
            int quantity = Convert.ToInt32(txt_quantity.Text);

            OrderItem item = new OrderItem(productname, quantity);
        }
    }
}
