using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace mi_libreria
{
    public class Utilidades
    {

        public static DataSet ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet Ds = new DataSet();
            SqlDataAdapter Dp = new SqlDataAdapter(cmd,con);

            Dp.Fill(Ds);
            con.Close();

            return Ds;

        }



    }
}
