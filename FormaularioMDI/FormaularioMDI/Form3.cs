using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaularioMDI
{
    public partial class txt_pass : Form
    {
        public txt_pass()
        {
            InitializeComponent();
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            string usuario, contrasena;
            usuario = txt_user.Text.TrimEnd();
            contrasena = txt_contra.Text.TrimEnd();

            if (usuario == "sebas" && contrasena == "123")
            {
                this.timer1.Start();
            }else
            {
                MessageBox.Show("contraseña incorrecta");
            }



                    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(1);
            if (ProgressBar1.Value == ProgressBar1.Maximum)
            {
                this.timer1.Stop();
                this.Close();
                Form4 form_4 = new Form4();
               
                form_4.Show();

                
            }

        }
    }
}
