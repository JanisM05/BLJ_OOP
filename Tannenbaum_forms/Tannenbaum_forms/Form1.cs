using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum_forms
{
    public partial class txt_tannenbaum : Form
    {
        public txt_tannenbaum()
        {
            InitializeComponent();
        }

        private void txt_tannenbaum_Load(object sender, EventArgs e)
        {

        }

        private void btn_zeichnen_Click(object sender, EventArgs e)
        {
            int stammbreite = Convert.ToInt32(txt_stammbreite.Text);
            int stammhoehe = Convert.ToInt32(txt_stammhoehe.Text);
            int kronenhohe = Convert.ToInt32(txt_kronenhoehe.Text);

            Tanne t = new Tanne(stammbreite, stammhoehe, kronenhohe);

            txt_finished.Text = t.getZeichnung();
        }
    }
}
