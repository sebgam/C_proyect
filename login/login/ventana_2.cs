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
    public partial class ventana_2 : Form
    {
        public ventana_2()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion;

            if (checkBox1.Checked == true)
            {
                cont++;
            }
            if (checkBox2.Checked == true)
            {
                cont++;
            }

            if (radioButton1.Checked == true)
            {
                seleccion = "efectivo";
            }else
            {
                seleccion = "tarjeta de credito";
            }

            MessageBox.Show("a seleccionado " + cont + " cursos  y su metodo de pago es " + seleccion);

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_1 = new Form1();
            form_1.Show();
        }
    }
}
