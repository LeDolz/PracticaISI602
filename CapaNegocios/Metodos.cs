using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace CapaNegocios
{
    public class Metodos
    {

        Conexion capadatos = new Conexion();
        String estadoConexion;

        public String AlternarConexion(bool abrir)
        {


            if (abrir) {
                estadoConexion = capadatos.AbrirConexion();
            }

            else {
                estadoConexion = "cerrar";
                //estadoConexion = capadatos.CerrarConexion();
            }
            
            return estadoConexion;

        }

        public void VolverFormAnterior(Form ventanaAnterior, Form ventanaActual)
        {
            ventanaAnterior.Show();
            ventanaActual.Close();
        }

        // intermediario capa datos-presentacion
        public string VerificarIngresoAnimal(string especie,
            string genero,
            string celda,
            DateTime fechaIngreso,
            bool vacunado)
        {

            capadatos.AbrirConexion();

            string resultado = capadatos.InsertarAnimal(especie,
                genero,
                celda,
                fechaIngreso,
                vacunado);

            return resultado;


        }

    }
}
