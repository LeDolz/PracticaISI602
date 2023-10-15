namespace CapaPresentacion.Forms
{
    partial class IngresoAnimal
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
            this.labelTituloIngreso = new System.Windows.Forms.Label();
            this.buttonVolverIngreso = new System.Windows.Forms.Button();
            this.tlpDatosUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxIngresoCelda = new System.Windows.Forms.TextBox();
            this.LabelIngresoCelda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNoVacunadoIngreso = new System.Windows.Forms.RadioButton();
            this.radioButtonSiVacunadoIngreso = new System.Windows.Forms.RadioButton();
            this.LabelIngresoVacunacion = new System.Windows.Forms.Label();
            this.labelIngresoGenero = new System.Windows.Forms.Label();
            this.dateTimePickerIngresoVacunacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxIngresoEspecieAnimal = new System.Windows.Forms.TextBox();
            this.labelIngresoEspecie = new System.Windows.Forms.Label();
            this.labelIngresoFechaIngreso = new System.Windows.Forms.Label();
            this.groupBoxRadioButtonGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonAnimalHembraIngreso = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimalMachoIngreso = new System.Windows.Forms.RadioButton();
            this.buttonIngresarAnimal = new System.Windows.Forms.Button();
            this.tlpDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxRadioButtonGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTituloIngreso
            // 
            this.labelTituloIngreso.AutoSize = true;
            this.labelTituloIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloIngreso.Location = new System.Drawing.Point(690, 47);
            this.labelTituloIngreso.Name = "labelTituloIngreso";
            this.labelTituloIngreso.Size = new System.Drawing.Size(319, 51);
            this.labelTituloIngreso.TabIndex = 2;
            this.labelTituloIngreso.Text = "Ingresar animal";
            // 
            // buttonVolverIngreso
            // 
            this.buttonVolverIngreso.AutoSize = true;
            this.buttonVolverIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverIngreso.Location = new System.Drawing.Point(12, 813);
            this.buttonVolverIngreso.Name = "buttonVolverIngreso";
            this.buttonVolverIngreso.Size = new System.Drawing.Size(84, 36);
            this.buttonVolverIngreso.TabIndex = 3;
            this.buttonVolverIngreso.Text = "Volver";
            this.buttonVolverIngreso.UseVisualStyleBackColor = true;
            this.buttonVolverIngreso.Click += new System.EventHandler(this.buttonVolverIngreso_Click);
            // 
            // tlpDatosUsuario
            // 
            this.tlpDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatosUsuario.ColumnCount = 2;
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17323F));
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82677F));
            this.tlpDatosUsuario.Controls.Add(this.textBoxIngresoCelda, 1, 4);
            this.tlpDatosUsuario.Controls.Add(this.LabelIngresoCelda, 0, 4);
            this.tlpDatosUsuario.Controls.Add(this.groupBox1, 1, 3);
            this.tlpDatosUsuario.Controls.Add(this.LabelIngresoVacunacion, 0, 3);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoGenero, 0, 2);
            this.tlpDatosUsuario.Controls.Add(this.dateTimePickerIngresoVacunacion, 1, 1);
            this.tlpDatosUsuario.Controls.Add(this.textBoxIngresoEspecieAnimal, 1, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoEspecie, 0, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoFechaIngreso, 0, 1);
            this.tlpDatosUsuario.Controls.Add(this.groupBoxRadioButtonGenero, 1, 2);
            this.tlpDatosUsuario.Location = new System.Drawing.Point(33, 182);
            this.tlpDatosUsuario.Name = "tlpDatosUsuario";
            this.tlpDatosUsuario.RowCount = 5;
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDatosUsuario.Size = new System.Drawing.Size(1510, 491);
            this.tlpDatosUsuario.TabIndex = 7;
            // 
            // textBoxIngresoCelda
            // 
            this.textBoxIngresoCelda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIngresoCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresoCelda.Location = new System.Drawing.Point(470, 419);
            this.textBoxIngresoCelda.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIngresoCelda.Name = "textBoxIngresoCelda";
            this.textBoxIngresoCelda.Size = new System.Drawing.Size(1040, 44);
            this.textBoxIngresoCelda.TabIndex = 12;
            // 
            // LabelIngresoCelda
            // 
            this.LabelIngresoCelda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIngresoCelda.AutoSize = true;
            this.LabelIngresoCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngresoCelda.Location = new System.Drawing.Point(3, 404);
            this.LabelIngresoCelda.Name = "LabelIngresoCelda";
            this.LabelIngresoCelda.Size = new System.Drawing.Size(464, 74);
            this.LabelIngresoCelda.TabIndex = 11;
            this.LabelIngresoCelda.Text = "Ingrese la celda en la cual se dejará al animal:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoVacunadoIngreso);
            this.groupBox1.Controls.Add(this.radioButtonSiVacunadoIngreso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonNoVacunadoIngreso
            // 
            this.radioButtonNoVacunadoIngreso.AutoSize = true;
            this.radioButtonNoVacunadoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoVacunadoIngreso.Location = new System.Drawing.Point(354, 35);
            this.radioButtonNoVacunadoIngreso.Name = "radioButtonNoVacunadoIngreso";
            this.radioButtonNoVacunadoIngreso.Size = new System.Drawing.Size(77, 41);
            this.radioButtonNoVacunadoIngreso.TabIndex = 1;
            this.radioButtonNoVacunadoIngreso.TabStop = true;
            this.radioButtonNoVacunadoIngreso.Text = "No";
            this.radioButtonNoVacunadoIngreso.UseVisualStyleBackColor = true;
            // 
            // radioButtonSiVacunadoIngreso
            // 
            this.radioButtonSiVacunadoIngreso.AutoSize = true;
            this.radioButtonSiVacunadoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSiVacunadoIngreso.Location = new System.Drawing.Point(67, 37);
            this.radioButtonSiVacunadoIngreso.Name = "radioButtonSiVacunadoIngreso";
            this.radioButtonSiVacunadoIngreso.Size = new System.Drawing.Size(63, 41);
            this.radioButtonSiVacunadoIngreso.TabIndex = 0;
            this.radioButtonSiVacunadoIngreso.TabStop = true;
            this.radioButtonSiVacunadoIngreso.Text = "Sí";
            this.radioButtonSiVacunadoIngreso.UseVisualStyleBackColor = true;
            // 
            // LabelIngresoVacunacion
            // 
            this.LabelIngresoVacunacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIngresoVacunacion.AutoSize = true;
            this.LabelIngresoVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngresoVacunacion.Location = new System.Drawing.Point(3, 306);
            this.LabelIngresoVacunacion.Name = "LabelIngresoVacunacion";
            this.LabelIngresoVacunacion.Size = new System.Drawing.Size(464, 74);
            this.LabelIngresoVacunacion.TabIndex = 10;
            this.LabelIngresoVacunacion.Text = "Se encuentra vacunado el animal?";
            // 
            // labelIngresoGenero
            // 
            this.labelIngresoGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoGenero.AutoSize = true;
            this.labelIngresoGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoGenero.Location = new System.Drawing.Point(3, 226);
            this.labelIngresoGenero.Name = "labelIngresoGenero";
            this.labelIngresoGenero.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoGenero.TabIndex = 8;
            this.labelIngresoGenero.Text = "Ingrese el género del animal";
            // 
            // dateTimePickerIngresoVacunacion
            // 
            this.dateTimePickerIngresoVacunacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerIngresoVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIngresoVacunacion.Location = new System.Drawing.Point(473, 125);
            this.dateTimePickerIngresoVacunacion.Name = "dateTimePickerIngresoVacunacion";
            this.dateTimePickerIngresoVacunacion.Size = new System.Drawing.Size(1034, 44);
            this.dateTimePickerIngresoVacunacion.TabIndex = 8;
            // 
            // textBoxIngresoEspecieAnimal
            // 
            this.textBoxIngresoEspecieAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIngresoEspecieAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresoEspecieAnimal.Location = new System.Drawing.Point(470, 27);
            this.textBoxIngresoEspecieAnimal.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIngresoEspecieAnimal.Name = "textBoxIngresoEspecieAnimal";
            this.textBoxIngresoEspecieAnimal.Size = new System.Drawing.Size(1040, 44);
            this.textBoxIngresoEspecieAnimal.TabIndex = 0;
            // 
            // labelIngresoEspecie
            // 
            this.labelIngresoEspecie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoEspecie.AutoSize = true;
            this.labelIngresoEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoEspecie.Location = new System.Drawing.Point(3, 30);
            this.labelIngresoEspecie.Name = "labelIngresoEspecie";
            this.labelIngresoEspecie.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoEspecie.TabIndex = 2;
            this.labelIngresoEspecie.Text = "Ingrese la especie del animal:";
            // 
            // labelIngresoFechaIngreso
            // 
            this.labelIngresoFechaIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoFechaIngreso.AutoSize = true;
            this.labelIngresoFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoFechaIngreso.Location = new System.Drawing.Point(3, 110);
            this.labelIngresoFechaIngreso.Name = "labelIngresoFechaIngreso";
            this.labelIngresoFechaIngreso.Size = new System.Drawing.Size(464, 74);
            this.labelIngresoFechaIngreso.TabIndex = 3;
            this.labelIngresoFechaIngreso.Text = "Ingrese la fecha del ingreso del animal:";
            // 
            // groupBoxRadioButtonGenero
            // 
            this.groupBoxRadioButtonGenero.Controls.Add(this.radioButtonAnimalHembraIngreso);
            this.groupBoxRadioButtonGenero.Controls.Add(this.radioButtonAnimalMachoIngreso);
            this.groupBoxRadioButtonGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBoxRadioButtonGenero.Location = new System.Drawing.Point(473, 199);
            this.groupBoxRadioButtonGenero.Name = "groupBoxRadioButtonGenero";
            this.groupBoxRadioButtonGenero.Size = new System.Drawing.Size(1034, 92);
            this.groupBoxRadioButtonGenero.TabIndex = 9;
            this.groupBoxRadioButtonGenero.TabStop = false;
            this.groupBoxRadioButtonGenero.Text = "groupBox1";
            // 
            // radioButtonAnimalHembraIngreso
            // 
            this.radioButtonAnimalHembraIngreso.AutoSize = true;
            this.radioButtonAnimalHembraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalHembraIngreso.Location = new System.Drawing.Point(354, 35);
            this.radioButtonAnimalHembraIngreso.Name = "radioButtonAnimalHembraIngreso";
            this.radioButtonAnimalHembraIngreso.Size = new System.Drawing.Size(177, 41);
            this.radioButtonAnimalHembraIngreso.TabIndex = 1;
            this.radioButtonAnimalHembraIngreso.TabStop = true;
            this.radioButtonAnimalHembraIngreso.Text = "Femenino";
            this.radioButtonAnimalHembraIngreso.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnimalMachoIngreso
            // 
            this.radioButtonAnimalMachoIngreso.AutoSize = true;
            this.radioButtonAnimalMachoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalMachoIngreso.Location = new System.Drawing.Point(67, 37);
            this.radioButtonAnimalMachoIngreso.Name = "radioButtonAnimalMachoIngreso";
            this.radioButtonAnimalMachoIngreso.Size = new System.Drawing.Size(179, 41);
            this.radioButtonAnimalMachoIngreso.TabIndex = 0;
            this.radioButtonAnimalMachoIngreso.TabStop = true;
            this.radioButtonAnimalMachoIngreso.Text = "Masculino";
            this.radioButtonAnimalMachoIngreso.UseVisualStyleBackColor = true;
            // 
            // buttonIngresarAnimal
            // 
            this.buttonIngresarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarAnimal.Location = new System.Drawing.Point(450, 775);
            this.buttonIngresarAnimal.Name = "buttonIngresarAnimal";
            this.buttonIngresarAnimal.Size = new System.Drawing.Size(700, 70);
            this.buttonIngresarAnimal.TabIndex = 8;
            this.buttonIngresarAnimal.Text = "Ingresar";
            this.buttonIngresarAnimal.UseVisualStyleBackColor = true;
            this.buttonIngresarAnimal.Click += new System.EventHandler(this.buttonIngresarAnimal_Click);
            // 
            // IngresoAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.buttonIngresarAnimal);
            this.Controls.Add(this.tlpDatosUsuario);
            this.Controls.Add(this.buttonVolverIngreso);
            this.Controls.Add(this.labelTituloIngreso);
            this.Name = "IngresoAnimal";
            this.Text = "Ingresar animales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoAnimal_FormClosing);
            this.Load += new System.EventHandler(this.IngresoAnimal_Load);
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

        private System.Windows.Forms.Label labelTituloIngreso;
        private System.Windows.Forms.Button buttonVolverIngreso;
        private System.Windows.Forms.TableLayoutPanel tlpDatosUsuario;
        private System.Windows.Forms.TextBox textBoxIngresoEspecieAnimal;
        private System.Windows.Forms.Label labelIngresoEspecie;
        private System.Windows.Forms.Label labelIngresoFechaIngreso;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngresoVacunacion;
        private System.Windows.Forms.Label labelIngresoGenero;
        private System.Windows.Forms.GroupBox groupBoxRadioButtonGenero;
        private System.Windows.Forms.RadioButton radioButtonAnimalMachoIngreso;
        private System.Windows.Forms.RadioButton radioButtonAnimalHembraIngreso;
        private System.Windows.Forms.Button buttonIngresarAnimal;
        private System.Windows.Forms.Label LabelIngresoVacunacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNoVacunadoIngreso;
        private System.Windows.Forms.RadioButton radioButtonSiVacunadoIngreso;
        private System.Windows.Forms.TextBox textBoxIngresoCelda;
        private System.Windows.Forms.Label LabelIngresoCelda;
    }
}