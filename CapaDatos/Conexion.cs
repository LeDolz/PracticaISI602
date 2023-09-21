using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {

        private string cadenaConexion = "Server=DOLZONARO\\SQLEXPRESS;Database=RefugioMascotas;Integrated Security=True;";
        private SqlConnection conexionSql = new SqlConnection();

        public string AbrirConexion()
        {
            try
            {
                conexionSql.ConnectionString = cadenaConexion;
                conexionSql.Open();
                return "Exito abrir";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Error abrir";
            }


        }
        public void CerrarConexion()
        {
            try
            {
                conexionSql.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }




        public String GetCadenaConexion()
        {
            return cadenaConexion;
        }


    }
}
