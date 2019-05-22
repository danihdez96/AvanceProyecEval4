using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CarSistem
{
    class Mantenimiento
    {
        CapaConexion cc = new CapaConexion();
        public DataTable dt = new DataTable();
        private String id_producto, nombre_pro;

        public String Nombre_pro
        {
            get { return nombre_pro; }
            set { nombre_pro = value; }
        }

        public String Id_producto
        {
            get { return id_producto; }
            set { id_producto = value; }
        }

        
        

        public void mostrarProd()
        {
            try
            {
                String consulta = "SELECT * FROM PRODUCTO";
                cc.Conectar();
                cc.ConsultaSQL(consulta);
                cc.Desconectar();
                cc.da.Fill(dt);
            }
            catch
            {

            }
        }

        public void insertProd()
        {
            try
            {
                String insert = "INSERT INTO PRODUCTO VALUES('" + id_producto + "','" + nombre_pro + "')";
                cc.Conectar();
                cc.ConsultaSQL(insert);
                cc.Desconectar();
            }
            catch
            {

            }
        }


        public void updateProd()
        {
            try
            {
                String update = "update PRODUCTO set nombre_prod='" + nombre_pro + "' where id_producto='" + id_producto + "'";
                cc.Conectar();
                cc.ConsultaSQL(update);
                cc.Desconectar();
            }
            catch
            {

            }
        }

        public void deleteProd()
        {
            try
            {
                String delete = "delete from PRODUCTO where id_producto='" + id_producto + "'";
                cc.Conectar();
                cc.ConsultaSQL(delete);
                cc.Desconectar();
            }
            catch
            {

            }
        }



        public String test()
        {
            String mensaje;
            if (cc.Conectar() == true)
            {
                cc.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                cc.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
    }
}
