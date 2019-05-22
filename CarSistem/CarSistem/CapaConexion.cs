
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CarSistem
{
    class CapaConexion
    {

        String CadenaConexion = "Data Source=.;Initial Catalog=CARBD;Persist Security Info=True;User ID=admin;Password=ad789";
        public SqlDataAdapter da;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public bool Conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public void ConsultaSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = "Conexion exitosa";
            }
            catch
            {
                mensaje = "Error al conectar";
            }

            }


             public void mostrarSQL(String consulta)
            {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                da = new SqlDataAdapter(comando);
                mensaje = "Correctamente";

            }
            catch
            {
                mensaje = "Error";
            }



        

        }
    }
}
