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
        private string mensajeError = "Error";

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

        public string InsertarAnimal(string especie, string genero, string celda, DateTime date, bool vacunado)
        {
            String sqlInsert = "INSERT INTO MASCOTAS " +
                "(especie, fechaIngreso, genero, vacunado, celda) " +
                "VALUES " +
                "(@especie, @fechaIngreso, @genero, @vacunado, @celda)";

            if (especie == string.Empty || genero == string.Empty || celda == string.Empty)
            {
                if (date > DateTime.Now)
                {
                    return "La fecha no es valida";
                }

                return "Alguno de los campos se encuentra incompleto";
            }

            using (SqlCommand comandoInsert = new SqlCommand(sqlInsert, conexionSql))
            {

                try
                {
                    comandoInsert.Parameters.AddWithValue("@especie", especie);
                    comandoInsert.Parameters.AddWithValue("@fechaIngreso", date);
                    comandoInsert.Parameters.AddWithValue("@genero", genero);
                    comandoInsert.Parameters.AddWithValue("@vacunado", vacunado);
                    comandoInsert.Parameters.AddWithValue("@celda", celda);

                    int filasAfectadas = comandoInsert.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return "Animal registrado con exito";
                    }
                    else
                    {
                        return "No se ha podido ingresar al animal";
                    }

                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

        }


        public String GetCadenaConexion()
        {
            return cadenaConexion;
        }


    }
}
