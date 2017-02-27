using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Pasar(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/user/Pictures/fit/13534546_256817961356632_1037510674_n.jpg";
        }

        private void salir(object sender, MouseEventArgs e)
        {
            
        }

        private void salga(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/user/Pictures/fit/13534355_1332495420113206_925589647_n.jpg";
        }
    }
}
