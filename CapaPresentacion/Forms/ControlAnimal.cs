﻿using CapaNegocios;
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
        Metodos capaNegocios = new Metodos();
        public ControlAnimal(Form ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            Login.CentrarTitulo(this.labelTituloControl, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capaNegocios.VolverFormAnterior(ventanaAnterior, this);
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

            int id = int.Parse(capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 0));
            string nuevaEspecie = capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 1);
            DateTime nuevaFechaIngreso = DateTime.Parse(capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 2));
            string nuevoGenero = capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 3);
            bool nuevaVacunacion = bool.Parse(capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 4));
            string celdaAnimal = capaNegocios.getIdSeleccionadaDgv(dgvAnimales, 5);


            try
            {


                EditarAnimal ventanaEditar = new EditarAnimal(this, 
                    id,
                    nuevaEspecie,
                    nuevaFechaIngreso,
                    nuevoGenero,
                    nuevaVacunacion,
                    celdaAnimal
                    );



                this.Visible = false;
                ventanaEditar.Visible = true;
                

                //TODO: traer datos del data grid view
            }
            catch {  }
            

        }

        private void ControlAnimal_Load(object sender, EventArgs e)
        {
            capaNegocios.AplicarDatosDGV(dgvAnimales);
        }
        private void ControlAnimal_Activated(object sender, EventArgs e)
        {
            capaNegocios.AplicarDatosDGV(dgvAnimales);
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            capaNegocios.EliminarAnimalDeCelda(dgvAnimales);
        }

        private void buttonBuscarMascota_Click(object sender, EventArgs e)
        {
            capaNegocios.BuscarAnimal(textBoxIngresarIdMascota, dgvAnimales);
        }
    }
}
