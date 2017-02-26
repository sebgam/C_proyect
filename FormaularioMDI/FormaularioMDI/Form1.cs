using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaularioMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();
            form_2.MdiParent = this;
            form_2.Show();

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_pass form_3 = new txt_pass();
            form_3.MdiParent = this;
            form_3.Show();
        }
    }
}
