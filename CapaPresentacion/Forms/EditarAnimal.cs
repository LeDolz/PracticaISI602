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

namespace CapaPresentacion.Forms
{
    public partial class EditarAnimal : Form
    {
        Form ventanaAnterior = null;
        public EditarAnimal(Form ventanaAnterior, String especieAnimal, DateTime fechaIngreso, String generoAnimal, bool vacunacionAnimal)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            Login.CentrarTitulo(labelTituloEditar, this);

            cargarDatos(especieAnimal, fechaIngreso, generoAnimal, vacunacionAnimal);

            //cambiar fecha del date time picker
            //this.dateTimePickerEditarVacunacion.Value = new DateTime(2020, 4, 24);
        }

        private void cargarDatos(string especieAnimal, DateTime fechaIngreso, string generoAnimal, bool vacunacionAnimal)
        {
            this.textBoxEditarEspecieAnimal.Text = especieAnimal;
            this.dateTimePickerEditarVacunacion.Value = fechaIngreso;

            if (generoAnimal.ToLower() == "h") { this.radioButtonAnimalHembraEditar.Checked = true; }
            else if (generoAnimal.ToLower() == "m") { this.radioButtonAnimalMachoEditar.Checked = true; }

            if (vacunacionAnimal) { this.radioButtonSiVacunadoEditar.Checked = true; }
            else { this.radioButtonNoVacunadoEditar.Checked = true; }

        }

        private void EditarAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaAnterior.Visible = true;
        }

        private void buttonVolverEditar_Click(object sender, EventArgs e)
        {


            //TODO: Volver a la ventana anterior, ahora este boton tan solo prueba la conexion
            Metodos metodo = new Metodos();
            textBoxEditarCelda.Text = metodo.AlternarConexion(true);
        }
    }
}
