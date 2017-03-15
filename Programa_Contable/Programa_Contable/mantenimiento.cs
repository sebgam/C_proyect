using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Contable
{
    public partial class mantenimiento : FormBase
    {
        public mantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nuevo();
        }
    }
}
