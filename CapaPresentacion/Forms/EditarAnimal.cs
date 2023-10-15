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
        Metodos capaDatos = new Metodos();
        int id;


        public EditarAnimal(Form ventanaAnterior, int id, String especieAnimal, DateTime fechaIngreso, String generoAnimal, bool vacunacionAnimal, string celdaAnimal)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            Login.CentrarTitulo(labelTituloEditar, this);
            this.id = id;

            cargarDatos(especieAnimal, fechaIngreso, generoAnimal, vacunacionAnimal, celdaAnimal);


        }

        private void cargarDatos(string especieAnimal, DateTime fechaIngreso, string generoAnimal, bool vacunacionAnimal, string celdaAnimal)
        {

            this.textBoxEditarEspecieAnimal.Text = especieAnimal;
            this.dateTimePickerEditarVacunacion.Value = fechaIngreso;

            if (generoAnimal.ToLower() == "f") { this.radioButtonAnimalHembraEditar.Checked = true; }
            else if (generoAnimal.ToLower() == "m") { this.radioButtonAnimalMachoEditar.Checked = true; }

            if (vacunacionAnimal) { this.radioButtonSiVacunadoEditar.Checked = true; }
            else { this.radioButtonNoVacunadoEditar.Checked = true; }

            this.textBoxEditarCelda.Text = celdaAnimal;

        }

        private void EditarAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaAnterior.Visible = true;
        }

        private void buttonVolverEditar_Click(object sender, EventArgs e)
        {

            capaDatos.VolverFormAnterior(ventanaAnterior, this);
            //TODO: Volver a la ventana anterior

        }

        private void buttonEditarAnimal_Click(object sender, EventArgs e)
        {
            string genero = (radioButtonAnimalMachoEditar.Checked) ? "M" : "F";


            string resultado = capaDatos.ActualizarDatosAnimal(
                    this.id,
                    textBoxEditarEspecieAnimal,
                    dateTimePickerEditarVacunacion,
                    genero,
                    radioButtonSiVacunadoEditar.Checked,
                    textBoxEditarCelda
                );





            Metodos.MostrarError(resultado);
        }
    }
}
