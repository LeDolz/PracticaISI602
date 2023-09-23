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
        Metodos capaNegocios = new Metodos();
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

        private void Login_Load(object sender, EventArgs e)
        {
            capaNegocios.AlternarConexion(true);
        }
    }

}
