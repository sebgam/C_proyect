using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mi_libreria;

namespace Programa_Contable
{
    public partial class mantenimientoCliente : mantenimiento
    {
        public mantenimientoCliente()
        {
            InitializeComponent();
        }

        //----------------------------------llama el metodo heredado de mantenimiento--------------------------------
        public override Boolean guardar()
        {
            try
            {
                if (txtIdCli.Text == "" || txtNomCli.Text == "" || txtApeCli.Text == "")//------valida que no haya campos vacios---------
                {
                    MessageBox.Show("por favor inserte todos los campos");
                    return false;
                }


                //--------------------llama procedimiento almacenado y pasa parametros-------------------------
                string cmd = string.Format("EXEC actulizaClientes'{0}','{1}','{2}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApeCli.Text.Trim());
                //---------------ejecuta consulta----------------------------
                Utilidades.ejecutar(cmd);

                lblhide1.Text = txtIdCli.Text.Trim();
                lblhide2.Text = txtNomCli.Text.Trim();
                lblhide3.Text = txtApeCli.Text.Trim();

                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();

                txtIdCli.Text = "";
                txtNomCli.Text = "";
                txtApeCli.Text = "";

                MessageBox.Show("se guardo correctamente");

                return true;//--------------retorna verdadero al metodo-----------------
            }
            catch (Exception error)
            {
                MessageBox.Show("ah ocurrido un error" + error.Message);
                return false;

            }
        }


        public override void eliminar()
        {
            try
            {

                string cmd = string.Format("EXEC eliminarClientes'{0}'", txtIdCli.Text.Trim());
                Utilidades.ejecutar(cmd);
                MessageBox.Show("se ah eliminado");

            }
            catch (Exception error)
            {

                MessageBox.Show("error " + error.Message);
            }




        }


        private void mantenimientoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'administracionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.administracionDataSet.Cliente);

        }
    }
}
