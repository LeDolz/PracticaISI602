using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using CapaDatos;
using System.Data;

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

        public void EliminarAnimalDeCelda(DataGridView dgv)
        {
            if (dgv.SelectedCells.Count>0)
            {
                DataGridViewCell celdaSeleccionada = dgv.SelectedCells[0];
                DataGridViewRow filaSeleccionada = dgv.Rows[celdaSeleccionada.RowIndex];


                object valorCelda = filaSeleccionada.Cells[0].Value;

                if (valorCelda != null)
                {
                    capadatos.EliminarAnimal(valorCelda.ToString());
                }

            }
            else
            {
                MostrarError("No hay celda seleccionada");
            }

            this.AplicarDatosDGV(dgv);
        }

        public void BuscarAnimal(TextBox cuadroBusqueda, DataGridView dgv)
        {
            DataTable tablaDatos = capadatos.BuscarAnimal(cuadroBusqueda.Text);



            if (cuadroBusqueda.Text == string.Empty)
            {
                MostrarError("Ingrese una id en el cuadro de búsqueda");
            }
            else if (tablaDatos.Rows.Count == 0)
            {
                MostrarError($"No hay animales con el ID {cuadroBusqueda.Text}");
            }
            else
            {
                dgv.DataSource = capadatos.BuscarAnimal(cuadroBusqueda.Text);
            }

        }

        public void AplicarDatosDGV(DataGridView dgv)
        {

            dgv.DataSource = capadatos.getDataAnimales();

        }


        // forms
        public void VolverFormAnterior(Form ventanaAnterior, Form ventanaActual)
        {
            ventanaAnterior.Show();
            ventanaActual.Close();
        }

        public static void MostrarError(string mensaje)
        {
            // Crea un nuevo formulario para mostrar el mensaje de error
            Form formularioError = new Form
            {
                Text = "Error",
                Size = new System.Drawing.Size(300, 150),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent
            };

            // Crea un label para mostrar el mensaje de error
            Label labelMensaje = new Label
            {
                Text = mensaje,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            // crear boton para salir
            Button botonSalir = new Button
            {
                Text = "Aceptar",
                Dock = DockStyle.Bottom
            };

            botonSalir.Click += (sender, e) =>
            {
                formularioError.Close();
            };

            // Agrega el label al formulario de error
            formularioError.Controls.Add(labelMensaje);
            formularioError.Controls.Add(botonSalir);

            // Muestra el formulario de error de manera modal (bloqueando la interacción con otros formularios)
            formularioError.ShowDialog();
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
