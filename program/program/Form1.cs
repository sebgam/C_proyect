using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string clave = txtPass.Text;
            Form2 form_2 = new Form2();
            if (clave =="1234")
            {

                form_2.Show();
               
            }
            else
            {
                MessageBox.Show("contraseña inbalida");
            }


        }
    }
}
