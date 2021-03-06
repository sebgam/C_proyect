﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using mi_libreria;//-------------------inserta libreria previamente creada--------------------------

namespace Programa_Contable
{
    public partial class login : FormBase
    {
        public login()
        {
            InitializeComponent();
        }


        public static string codigo = "";

        private void iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                //-------------------consulta sql-----------------------------

                string CMD = string.Format("SELECT * FROM Usuarios WHERE account = '{0}' AND password ='{1}'", txtNom.Text.Trim(), txtPass.Text.Trim());

                //----------------ejecuta consulta----------------------------------------------
                DataSet ds = Utilidades.ejecutar(CMD);

                //----------------------trae datos de base de datos----------------------------------
                codigo = ds.Tables[0].Rows[0]["Id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                string admin = ds.Tables[0].Rows[0]["Status_admin"].ToString().Trim();

                //--------------------validaciones--------------------------------------
                if (cuenta == txtNom.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(admin) == true  )
                    {
                       
                        ventanaAdmin venAdmin = new ventanaAdmin();
                        this.Hide();
                        venAdmin.Show();
                    }else
                    {
                        ventanaUser venUser = new ventanaUser();
                        this.Hide();
                        venUser.Show();
                    }
                }
               

            }
            catch (Exception)
            {

                MessageBox.Show("usuario o contraseña incorrectos" + txtNom.Text);
            }
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
