using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaPresentacion.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        Metodos metodo = new Metodos();
        public Login()
        {
            InitializeComponent();
            CentrarTitulo(labelBienvenido, this);
            buttonIngresar.Left = (ClientSize.Width - buttonIngresar.Width) / 2;


            //verificar conexion
            //this.labelBienvenido.Text = metodo.AlternarConexion(true);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LimpiarTextBoxes();
            ControlAnimal nuevaVentana = new ControlAnimal(this);
            nuevaVentana.Visible = true;
        }

        public static void CentrarTitulo(Label label, Form form)
        {
            label.Size = form.ClientSize;
            label.Left = (form.ClientSize.Width - label.Width) / 2;

        }

        public void LimpiarTextBoxes()
        {
            textBoxUsuario.Text = string.Empty;
            textBoxContrasenia.Text = string.Empty;

        }


        public static void MostrarError(string mensaje)
        {
            // Crea un nuevo formulario para mostrar el mensaje de error
            Form formularioError = new Form();
            formularioError.Text = "Error";
            formularioError.Size = new System.Drawing.Size(300, 150);
            formularioError.FormBorderStyle = FormBorderStyle.FixedDialog;
            formularioError.StartPosition = FormStartPosition.CenterParent;

            // Crea un label para mostrar el mensaje de error
            Label labelMensaje = new Label();
            labelMensaje.Text = mensaje;
            labelMensaje.Dock = DockStyle.Fill;
            labelMensaje.TextAlign = ContentAlignment.MiddleCenter;

            // crear boton para salir
            Button botonSalir = new Button();
            botonSalir.Text = "Aceptar";
            botonSalir.Dock = DockStyle.Bottom;

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



    }

}
