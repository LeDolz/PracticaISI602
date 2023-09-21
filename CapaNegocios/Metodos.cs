using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
