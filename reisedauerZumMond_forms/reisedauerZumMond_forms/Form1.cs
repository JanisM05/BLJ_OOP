using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reisedauerZumMond_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            int distance = 384000;
            int speed;
            string time = "";
            if (rb_days.Checked == true)
            {
                time = "Tage";
                lbl_einheit.Text = "Tage";
            }
            else
            {
                time = "Stunden";
                lbl_einheit.Text = "Stunden";
            }

            speed = Convert.ToInt32(txt_speed.Text);

            Mondreise m = new Mondreise(time, speed, distance);

            lbl_ergebnis.Text = Convert.ToString(m.getTime());
        }
    }
}
