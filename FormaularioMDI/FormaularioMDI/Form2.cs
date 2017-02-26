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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Minimum = 1;
            progressBar1.Maximum = 1000;
            progressBar1.Value = 1;
            progressBar1.Step =1;

            for (int i = 0; i < 1000; i++)
            {
               
                progressBar1.PerformStep();
                
            }

            if (progressBar1.Value == 1000)
            {
                this.Close();
            }

        }
    }
}
