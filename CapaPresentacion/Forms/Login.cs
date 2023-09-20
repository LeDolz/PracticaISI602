using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CentrarTitulo(labelBienvenido, this);
            buttonIngresar.Left = (ClientSize.Width - buttonIngresar.Width) / 2;

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
            //centrar el ancho
            label.Left = (form.ClientSize.Width - label.Width) / 2;

            //centrar el alto
            //labelBienvenido.Top = (this.ClientSize.Height - labelBienvenido.Height) / 2;

            //labelUsuario.Size = this.ClientSize;

        }

        public void LimpiarTextBoxes()
        {
            textBoxUsuario.Text = string.Empty;
            textBoxContrasenia.Text = string.Empty;

        }

    }

}
