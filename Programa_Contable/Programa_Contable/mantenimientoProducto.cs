using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mi_libreria;//----------------trae libreria de conexion

namespace Programa_Contable
{
    public partial class mantenimientoProducto : mantenimiento
    {
        public mantenimientoProducto()
        {
            InitializeComponent();
        }

        //----------------------------------llama el metodo heredado de mantenimiento--------------------------------
        public override Boolean guardar()
        {
            try
            {
                if (txtIdPro.Text == "" || txtDesPro.Text == "" || txtPrePro.Text == "")
                {
                    MessageBox.Show("por favor inserte todos los campos");
                    return false;
                }


                //--------------------llama procedimiento almacenado y pasa parametros-------------------------
                string cmd = string.Format("EXEC actulizaArticulos'{0}','{1}','{2}'", txtIdPro.Text.Trim(), txtDesPro.Text.Trim(), txtPrePro.Text.Trim());
                //---------------ejecuta consulta----------------------------
                Utilidades.ejecutar(cmd);

                lblhide1.Text = txtIdPro.Text.Trim();
                lblhide2.Text = txtDesPro.Text.Trim();
                lblhide3.Text = txtPrePro.Text.Trim();

                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();

                txtIdPro.Text = "";
                txtDesPro.Text = "";
                txtPrePro.Text = "";

                MessageBox.Show("se guardo correctamente");

                return true;//--------------retorna verdadero al metodo-----------------
            }
            catch (Exception error)
            {
                MessageBox.Show("ah ocurrido un error" + error.Message);
                return false;
                
            }
        }



        private void mantenimientoProducto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
