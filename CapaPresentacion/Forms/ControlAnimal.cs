using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class ControlAnimal : Form
    {
        Form ventanaAnterior = null;
        Metodos capaDatos = new Metodos();
        public ControlAnimal(Form ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            Login.CentrarTitulo(this.labelTituloControl, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capaDatos.VolverFormAnterior(ventanaAnterior, this);
        }




        private void ControlMascotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaAnterior.Visible=true;
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IngresoAnimal ventanaIngreso = new IngresoAnimal(this);
            ventanaIngreso.Visible = true;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarAnimal ventanaEditar = new EditarAnimal(this, "MEME", new DateTime(1992, 3, 21), "H", true);
                this.Visible = false;
                ventanaEditar.Visible = true;

                //TODO: traer datos del data grid view
            }
            catch { }

        }
    }
}
