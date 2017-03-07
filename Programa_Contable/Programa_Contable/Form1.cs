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
using mi_libreria;

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
            try
            {
                string CMD = string.Format("SELECT * FROM Usuarios WHERE account = '{0}' AND password ='{1}'", txtPass.Text.Trim(), txtNomAcc.Text.Trim());

                DataSet ds = Utilidades.ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == txtPass.Text.Trim() && contra == txtNomAcc.Text.Trim())
                {
                    MessageBox.Show("se ha iniciado");
                }
               

            }
            catch (Exception)
            {

                MessageBox.Show("usuario o contraseña incorrectos");
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
