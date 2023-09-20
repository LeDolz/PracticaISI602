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
        public ControlAnimal(Form ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            Login.CentrarTitulo(this.labelTituloControl, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaAnterior.Visible = true;
            this.Close();
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
    }
}
