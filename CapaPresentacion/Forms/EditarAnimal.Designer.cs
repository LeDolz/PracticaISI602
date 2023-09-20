namespace CapaPresentacion.Forms
{
    partial class EditarAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTituloEditar = new System.Windows.Forms.Label();
            this.tlpDatosUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNoVacunadoEditar = new System.Windows.Forms.RadioButton();
            this.radioButtonSiVacunadoEditar = new System.Windows.Forms.RadioButton();
            this.LabelEditarVacunacion = new System.Windows.Forms.Label();
            this.labelEditarGeneroAnimal = new System.Windows.Forms.Label();
            this.dateTimePickerEditarVacunacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditarEspecieAnimal = new System.Windows.Forms.TextBox();
            this.labelEditarEspecieAnimal = new System.Windows.Forms.Label();
            this.labelEditarFechaIngreso = new System.Windows.Forms.Label();
            this.groupBoxRadioButtonGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonAnimalHembraEditar = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimalMachoEditar = new System.Windows.Forms.RadioButton();
            this.labelInfoEditar = new System.Windows.Forms.Label();
            this.tlpDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRadioButtonGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloEditar
            // 
            this.labelTituloEditar.AutoSize = true;
            this.labelTituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloEditar.Location = new System.Drawing.Point(690, 47);
            this.labelTituloEditar.Name = "labelTituloEditar";
            this.labelTituloEditar.Size = new System.Drawing.Size(460, 51);
            this.labelTituloEditar.TabIndex = 3;
            this.labelTituloEditar.Text = "Editar datos del animal";
            // 
            // tlpDatosUsuario
            // 
            this.tlpDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatosUsuario.ColumnCount = 2;
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17323F));
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82677F));
            this.tlpDatosUsuario.Controls.Add(this.groupBox1, 1, 3);
            this.tlpDatosUsuario.Controls.Add(this.LabelEditarVacunacion, 0, 3);
            this.tlpDatosUsuario.Controls.Add(this.labelEditarGeneroAnimal, 0, 2);
            this.tlpDatosUsuario.Controls.Add(this.dateTimePickerEditarVacunacion, 1, 1);
            this.tlpDatosUsuario.Controls.Add(this.textBoxEditarEspecieAnimal, 1, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelEditarEspecieAnimal, 0, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelEditarFechaIngreso, 0, 1);
            this.tlpDatosUsuario.Controls.Add(this.groupBoxRadioButtonGenero, 1, 2);
            this.tlpDatosUsuario.Location = new System.Drawing.Point(37, 267);
            this.tlpDatosUsuario.Name = "tlpDatosUsuario";
            this.tlpDatosUsuario.RowCount = 4;
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.Size = new System.Drawing.Size(1510, 491);
            this.tlpDatosUsuario.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoVacunadoEditar);
            this.groupBox1.Controls.Add(this.radioButtonSiVacunadoEditar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonNoVacunadoEditar
            // 
            this.radioButtonNoVacunadoEditar.AutoSize = true;
            this.radioButtonNoVacunadoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoVacunadoEditar.Location = new System.Drawing.Point(354, 35);
            this.radioButtonNoVacunadoEditar.Name = "radioButtonNoVacunadoEditar";
            this.radioButtonNoVacunadoEditar.Size = new System.Drawing.Size(77, 41);
            this.radioButtonNoVacunadoEditar.TabIndex = 1;
            this.radioButtonNoVacunadoEditar.TabStop = true;
            this.radioButtonNoVacunadoEditar.Text = "No";
            this.radioButtonNoVacunadoEditar.UseVisualStyleBackColor = true;
            // 
            // radioButtonSiVacunadoEditar
            // 
            this.radioButtonSiVacunadoEditar.AutoSize = true;
            this.radioButtonSiVacunadoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSiVacunadoEditar.Location = new System.Drawing.Point(67, 37);
            this.radioButtonSiVacunadoEditar.Name = "radioButtonSiVacunadoEditar";
            this.radioButtonSiVacunadoEditar.Size = new System.Drawing.Size(63, 41);
            this.radioButtonSiVacunadoEditar.TabIndex = 0;
            this.radioButtonSiVacunadoEditar.TabStop = true;
            this.radioButtonSiVacunadoEditar.Text = "Sí";
            this.radioButtonSiVacunadoEditar.UseVisualStyleBackColor = true;
            // 
            // LabelEditarVacunacion
            // 
            this.LabelEditarVacunacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelEditarVacunacion.AutoSize = true;
            this.LabelEditarVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEditarVacunacion.Location = new System.Drawing.Point(3, 391);
            this.LabelEditarVacunacion.Name = "LabelEditarVacunacion";
            this.LabelEditarVacunacion.Size = new System.Drawing.Size(464, 74);
            this.LabelEditarVacunacion.TabIndex = 10;
            this.LabelEditarVacunacion.Text = "Se encuentra vacunado el animal?";
            // 
            // labelEditarGeneroAnimal
            // 
            this.labelEditarGeneroAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditarGeneroAnimal.AutoSize = true;
            this.labelEditarGeneroAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarGeneroAnimal.Location = new System.Drawing.Point(3, 286);
            this.labelEditarGeneroAnimal.Name = "labelEditarGeneroAnimal";
            this.labelEditarGeneroAnimal.Size = new System.Drawing.Size(464, 37);
            this.labelEditarGeneroAnimal.TabIndex = 8;
            this.labelEditarGeneroAnimal.Text = "Nuevo género del animal:";
            // 
            // dateTimePickerEditarVacunacion
            // 
            this.dateTimePickerEditarVacunacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEditarVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEditarVacunacion.Location = new System.Drawing.Point(473, 161);
            this.dateTimePickerEditarVacunacion.Name = "dateTimePickerEditarVacunacion";
            this.dateTimePickerEditarVacunacion.Size = new System.Drawing.Size(1034, 44);
            this.dateTimePickerEditarVacunacion.TabIndex = 8;
            // 
            // textBoxEditarEspecieAnimal
            // 
            this.textBoxEditarEspecieAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditarEspecieAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditarEspecieAnimal.Location = new System.Drawing.Point(470, 39);
            this.textBoxEditarEspecieAnimal.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxEditarEspecieAnimal.Name = "textBoxEditarEspecieAnimal";
            this.textBoxEditarEspecieAnimal.Size = new System.Drawing.Size(1040, 44);
            this.textBoxEditarEspecieAnimal.TabIndex = 0;
            // 
            // labelEditarEspecieAnimal
            // 
            this.labelEditarEspecieAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditarEspecieAnimal.AutoSize = true;
            this.labelEditarEspecieAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarEspecieAnimal.Location = new System.Drawing.Point(3, 42);
            this.labelEditarEspecieAnimal.Name = "labelEditarEspecieAnimal";
            this.labelEditarEspecieAnimal.Size = new System.Drawing.Size(464, 37);
            this.labelEditarEspecieAnimal.TabIndex = 2;
            this.labelEditarEspecieAnimal.Text = "Nueva especie del animal:";
            // 
            // labelEditarFechaIngreso
            // 
            this.labelEditarFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditarFechaIngreso.AutoSize = true;
            this.labelEditarFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarFechaIngreso.Location = new System.Drawing.Point(3, 146);
            this.labelEditarFechaIngreso.Name = "labelEditarFechaIngreso";
            this.labelEditarFechaIngreso.Size = new System.Drawing.Size(464, 74);
            this.labelEditarFechaIngreso.TabIndex = 3;
            this.labelEditarFechaIngreso.Text = "Nueva fecha de ingreso del animal:";
            // 
            // groupBoxRadioButtonGenero
            // 
            this.groupBoxRadioButtonGenero.Controls.Add(this.radioButtonAnimalHembraEditar);
            this.groupBoxRadioButtonGenero.Controls.Add(this.radioButtonAnimalMachoEditar);
            this.groupBoxRadioButtonGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBoxRadioButtonGenero.Location = new System.Drawing.Point(473, 247);
            this.groupBoxRadioButtonGenero.Name = "groupBoxRadioButtonGenero";
            this.groupBoxRadioButtonGenero.Size = new System.Drawing.Size(1034, 116);
            this.groupBoxRadioButtonGenero.TabIndex = 9;
            this.groupBoxRadioButtonGenero.TabStop = false;
            this.groupBoxRadioButtonGenero.Text = "groupBox1";
            // 
            // radioButtonAnimalHembraEditar
            // 
            this.radioButtonAnimalHembraEditar.AutoSize = true;
            this.radioButtonAnimalHembraEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalHembraEditar.Location = new System.Drawing.Point(354, 35);
            this.radioButtonAnimalHembraEditar.Name = "radioButtonAnimalHembraEditar";
            this.radioButtonAnimalHembraEditar.Size = new System.Drawing.Size(149, 41);
            this.radioButtonAnimalHembraEditar.TabIndex = 1;
            this.radioButtonAnimalHembraEditar.TabStop = true;
            this.radioButtonAnimalHembraEditar.Text = "Hembra";
            this.radioButtonAnimalHembraEditar.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnimalMachoEditar
            // 
            this.radioButtonAnimalMachoEditar.AutoSize = true;
            this.radioButtonAnimalMachoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalMachoEditar.Location = new System.Drawing.Point(67, 37);
            this.radioButtonAnimalMachoEditar.Name = "radioButtonAnimalMachoEditar";
            this.radioButtonAnimalMachoEditar.Size = new System.Drawing.Size(131, 41);
            this.radioButtonAnimalMachoEditar.TabIndex = 0;
            this.radioButtonAnimalMachoEditar.TabStop = true;
            this.radioButtonAnimalMachoEditar.Text = "Macho";
            this.radioButtonAnimalMachoEditar.UseVisualStyleBackColor = true;
            // 
            // labelInfoEditar
            // 
            this.labelInfoEditar.AutoSize = true;
            this.labelInfoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoEditar.Location = new System.Drawing.Point(44, 173);
            this.labelInfoEditar.Name = "labelInfoEditar";
            this.labelInfoEditar.Size = new System.Drawing.Size(919, 37);
            this.labelInfoEditar.TabIndex = 9;
            this.labelInfoEditar.Text = "Deje el campo de texto en blanco para no realizar canbios en el";
            // 
            // EditarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.labelInfoEditar);
            this.Controls.Add(this.tlpDatosUsuario);
            this.Controls.Add(this.labelTituloEditar);
            this.Name = "EditarAnimal";
            this.Text = "EditarAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarAnimal_FormClosing);
            this.tlpDatosUsuario.ResumeLayout(false);
            this.tlpDatosUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRadioButtonGenero.ResumeLayout(false);
            this.groupBoxRadioButtonGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloEditar;
        private System.Windows.Forms.TableLayoutPanel tlpDatosUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNoVacunadoEditar;
        private System.Windows.Forms.RadioButton radioButtonSiVacunadoEditar;
        private System.Windows.Forms.Label LabelEditarVacunacion;
        private System.Windows.Forms.Label labelEditarGeneroAnimal;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditarVacunacion;
        private System.Windows.Forms.TextBox textBoxEditarEspecieAnimal;
        private System.Windows.Forms.Label labelEditarEspecieAnimal;
        private System.Windows.Forms.Label labelEditarFechaIngreso;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonGenero;
        private System.Windows.Forms.RadioButton radioButtonAnimalHembraEditar;
        private System.Windows.Forms.RadioButton radioButtonAnimalMachoEditar;
        private System.Windows.Forms.Label labelInfoEditar;
    }
}