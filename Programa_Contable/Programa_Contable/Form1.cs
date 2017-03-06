using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Programa_Contable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {

            //--------------conexion a base de datos-------------------------------
            try
            {
               
                MessageBox.Show("se ah conectado correctamente a la base de datos");
            }
            catch (Exception error)
            {

                MessageBox.Show("a ocurrido un error" + error.Message);
            }
            

        }
    }
}
