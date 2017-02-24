using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (user.Text == "sebas" && pass.Text == "123")
            {
                MessageBox.Show("correcto se inicio sesion");
            }else
            {
                MessageBox.Show("error en id o pass");
                pass.Text = "";
                user.Text = "";
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
