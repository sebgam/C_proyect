﻿using System;
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
    public partial class ventanaAdmin : Form

    {
      
        public ventanaAdmin()
        {
            InitializeComponent();
        }

        private void ventanaAdmin_Load(object sender, EventArgs e)
        {
            //--------------------consulta---------------------
            string cmd = "SELECT * FROM Usuarios WHERE Id_usuario =" + login.codigo;


            //--------------------------ejecuta consulta------------------------
            DataSet ds = Utilidades.ejecutar(cmd);


            //-----------------------------------------llama datos de la base de datos----------------------
            lblAdmin.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsuario.Text = ds.Tables[0].Rows[0]["Account"].ToString();
            lblCodigo.Text = ds.Tables[0].Rows[0]["Id_usuario"].ToString();

            //------------url imagen-------------------
            string url = ds.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);//------carga imagen desde base de datos----------


        }

        private void ventanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
