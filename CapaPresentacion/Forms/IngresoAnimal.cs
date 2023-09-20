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
    public partial class IngresoAnimal : Form
    {
        Form ventanaAnterior = null;
        public IngresoAnimal(Form ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }

        private void IngresoAnimal_Load(object sender, EventArgs e)
        {
            Login.CentrarTitulo(this.labelTituloIngreso, this);


        }

        private void IngresoAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaAnterior.Visible=true;
        }

        private void buttonIngresarAnimal_Click(object sender, EventArgs e)
        {

            //verificar el radiobutton
            Form popup = new Form();
            
            popup.ShowDialog();
        }
    }
}
