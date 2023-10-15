using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {

        //private string cadenaConexion = "Server=DOLZONARO\\SQLEXPRESS;Database=RefugioMascotas;Integrated Security=True;";
        private SqlConnection conexionSql = new SqlConnection("Server=DOLZONARO\\SQLEXPRESS;Database=RefugioMascotas;Integrated Security=True;");
        //private string mensajeError = "Error";

        public string AbrirConexion()
        {
            try
            {
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

        public DataTable getDataAnimales()
        {
            string sqlSelect = "SELECT * FROM MASCOTAS";

            SqlDataAdapter adaptador = new SqlDataAdapter(sqlSelect, conexionSql);
            DataTable datos = new DataTable();
            adaptador.Fill(datos);
            return datos;
            

        }
        public DataTable BuscarAnimal(string id)
        {
            string sqlSelect = "SELECT * FROM MASCOTAS WHERE id LIKE @id";

            using (SqlCommand cmd = new SqlCommand(sqlSelect, conexionSql))
            {
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;


            }

            /*
            SqlCommand cmd = new SqlCommand(sqlSelect, conexionSql);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            return datos;
            */
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

        public string ActualizarAnimal(int id, string especie, DateTime fechaIngreso, string genero, bool vacunado, string celda)
        {

            string sqlActualizarAnimal = "UPDATE Mascotas SET " +
                "especie = @especie, fechaIngreso = @fechaIngreso, genero = @genero, vacunado = @vacunado, celda = @celda" +
                " WHERE id = @id;";

            using (SqlCommand comandoActualizar = new SqlCommand(sqlActualizarAnimal, conexionSql))
            {
                this.AbrirConexion();
                try
                {
                    comandoActualizar.Parameters.AddWithValue("@id", id);
                    comandoActualizar.Parameters.AddWithValue("@especie", especie);
                    comandoActualizar.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    comandoActualizar.Parameters.AddWithValue("@genero", genero);
                    comandoActualizar.Parameters.AddWithValue("@vacunado", vacunado);
                    comandoActualizar.Parameters.AddWithValue("@celda", celda);

                    int filasAfectadas = comandoActualizar.ExecuteNonQuery();
                    this.CerrarConexion();
                    if (filasAfectadas > 0)
                    {
                        return "Se ha actualizado el animal";
                    }
                    else
                    {
                        return "No se ha podido actualizar el animal";
                    }

                }catch (Exception ex)
                {
                    return ex.Message;
                }

            }


        }



        public string EliminarAnimal(string id)
        {

            string sqlDelete = "DELETE FROM MASCOTAS WHERE id = @id";

            using (SqlCommand comandoDelete = new SqlCommand(sqlDelete, conexionSql))
            {
                conexionSql.Open();
                comandoDelete.Parameters.AddWithValue("@id", id);
                int filasAfectadas = comandoDelete.ExecuteNonQuery();
                conexionSql.Close();
                if (filasAfectadas>0)
                {
                    return $"Registro con ID = {id} ha sido eliminado";
                }
                else
                {
                    return $"No existe registro con ID = {id}";
                }

            }
        }


        public string[] BuscarUsuario(string nombreUsuario, string clave)
        {

            string sqlBuscaUsuario = "SELECT * FROM Empleados WHERE nombreUsuario = @nombreUsuario AND clave = @clave";

            
            using (SqlCommand comandoBuscarUser = new SqlCommand(sqlBuscaUsuario, conexionSql))
            {
                comandoBuscarUser.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comandoBuscarUser.Parameters.AddWithValue("@clave", clave);


                using (SqlDataReader reader = comandoBuscarUser.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        string[] datos = new string[2];
                        datos[0] = reader["nombreUsuario"].ToString();
                        datos[1] = reader["clave"].ToString();

                        return datos;
                    }else {
                        string[] datosVacios = new string[2];
                        return datosVacios; 
                    }

                }

            }
            
        }



    }
}
