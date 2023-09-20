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
            this.textBoxIngresoEspecieAnimal = new System.Windows.Forms.TextBox();
            this.labelIngresoEspecieAnimal = new System.Windows.Forms.Label();
            this.labelIngresoVacunacionAnimal = new System.Windows.Forms.Label();
            this.dateTimePickerIngresoVacunacion = new System.Windows.Forms.DateTimePicker();
            this.labelIngresoGeneroAnimal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAnimalMacho = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimalHembra = new System.Windows.Forms.RadioButton();
            this.buttonIngresarAnimal = new System.Windows.Forms.Button();
            this.tlpDatosUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // tlpDatosUsuario
            // 
            this.tlpDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatosUsuario.ColumnCount = 2;
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17323F));
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82677F));
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoGeneroAnimal, 0, 2);
            this.tlpDatosUsuario.Controls.Add(this.dateTimePickerIngresoVacunacion, 1, 1);
            this.tlpDatosUsuario.Controls.Add(this.textBoxIngresoEspecieAnimal, 1, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoEspecieAnimal, 0, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoVacunacionAnimal, 0, 1);
            this.tlpDatosUsuario.Controls.Add(this.groupBox1, 1, 2);
            this.tlpDatosUsuario.Location = new System.Drawing.Point(33, 182);
            this.tlpDatosUsuario.Name = "tlpDatosUsuario";
            this.tlpDatosUsuario.RowCount = 3;
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDatosUsuario.Size = new System.Drawing.Size(1510, 491);
            this.tlpDatosUsuario.TabIndex = 7;
            // 
            // textBoxIngresoEspecieAnimal
            // 
            this.textBoxIngresoEspecieAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIngresoEspecieAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresoEspecieAnimal.Location = new System.Drawing.Point(470, 59);
            this.textBoxIngresoEspecieAnimal.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIngresoEspecieAnimal.Name = "textBoxIngresoEspecieAnimal";
            this.textBoxIngresoEspecieAnimal.Size = new System.Drawing.Size(1040, 44);
            this.textBoxIngresoEspecieAnimal.TabIndex = 0;
            // 
            // labelIngresoEspecieAnimal
            // 
            this.labelIngresoEspecieAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoEspecieAnimal.AutoSize = true;
            this.labelIngresoEspecieAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoEspecieAnimal.Location = new System.Drawing.Point(3, 63);
            this.labelIngresoEspecieAnimal.Name = "labelIngresoEspecieAnimal";
            this.labelIngresoEspecieAnimal.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoEspecieAnimal.TabIndex = 2;
            this.labelIngresoEspecieAnimal.Text = "Ingrese su nombre de usuario:";
            // 
            // labelIngresoVacunacionAnimal
            // 
            this.labelIngresoVacunacionAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoVacunacionAnimal.AutoSize = true;
            this.labelIngresoVacunacionAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoVacunacionAnimal.Location = new System.Drawing.Point(3, 226);
            this.labelIngresoVacunacionAnimal.Name = "labelIngresoVacunacionAnimal";
            this.labelIngresoVacunacionAnimal.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoVacunacionAnimal.TabIndex = 3;
            this.labelIngresoVacunacionAnimal.Text = "Ingrese su contraseña:";
            // 
            // dateTimePickerIngresoVacunacion
            // 
            this.dateTimePickerIngresoVacunacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerIngresoVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIngresoVacunacion.Location = new System.Drawing.Point(473, 222);
            this.dateTimePickerIngresoVacunacion.Name = "dateTimePickerIngresoVacunacion";
            this.dateTimePickerIngresoVacunacion.Size = new System.Drawing.Size(1034, 44);
            this.dateTimePickerIngresoVacunacion.TabIndex = 8;
            // 
            // labelIngresoGeneroAnimal
            // 
            this.labelIngresoGeneroAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoGeneroAnimal.AutoSize = true;
            this.labelIngresoGeneroAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoGeneroAnimal.Location = new System.Drawing.Point(3, 390);
            this.labelIngresoGeneroAnimal.Name = "labelIngresoGeneroAnimal";
            this.labelIngresoGeneroAnimal.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoGeneroAnimal.TabIndex = 8;
            this.labelIngresoGeneroAnimal.Text = "Ingrese el género del animal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAnimalHembra);
            this.groupBox1.Controls.Add(this.radioButtonAnimalMacho);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(473, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonAnimalMacho
            // 
            this.radioButtonAnimalMacho.AutoSize = true;
            this.radioButtonAnimalMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalMacho.Location = new System.Drawing.Point(193, 57);
            this.radioButtonAnimalMacho.Name = "radioButtonAnimalMacho";
            this.radioButtonAnimalMacho.Size = new System.Drawing.Size(131, 41);
            this.radioButtonAnimalMacho.TabIndex = 0;
            this.radioButtonAnimalMacho.TabStop = true;
            this.radioButtonAnimalMacho.Text = "Macho";
            this.radioButtonAnimalMacho.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnimalHembra
            // 
            this.radioButtonAnimalHembra.AutoSize = true;
            this.radioButtonAnimalHembra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnimalHembra.Location = new System.Drawing.Point(354, 57);
            this.radioButtonAnimalHembra.Name = "radioButtonAnimalHembra";
            this.radioButtonAnimalHembra.Size = new System.Drawing.Size(149, 41);
            this.radioButtonAnimalHembra.TabIndex = 1;
            this.radioButtonAnimalHembra.TabStop = true;
            this.radioButtonAnimalHembra.Text = "Hembra";
            this.radioButtonAnimalHembra.UseVisualStyleBackColor = true;
            // 
            // buttonIngresarAnimal
            // 
            this.buttonIngresarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresarAnimal.Location = new System.Drawing.Point(444, 775);
            this.buttonIngresarAnimal.Name = "buttonIngresarAnimal";
            this.buttonIngresarAnimal.Size = new System.Drawing.Size(686, 74);
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
            this.Text = "IngresoAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoAnimal_FormClosing);
            this.Load += new System.EventHandler(this.IngresoAnimal_Load);
            this.tlpDatosUsuario.ResumeLayout(false);
            this.tlpDatosUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloIngreso;
        private System.Windows.Forms.Button buttonVolverIngreso;
        private System.Windows.Forms.TableLayoutPanel tlpDatosUsuario;
        private System.Windows.Forms.TextBox textBoxIngresoEspecieAnimal;
        private System.Windows.Forms.Label labelIngresoEspecieAnimal;
        private System.Windows.Forms.Label labelIngresoVacunacionAnimal;
        private System.Windows.Forms.DateTimePicker dateTimePickerIngresoVacunacion;
        private System.Windows.Forms.Label labelIngresoGeneroAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAnimalMacho;
        private System.Windows.Forms.RadioButton radioButtonAnimalHembra;
        private System.Windows.Forms.Button buttonIngresarAnimal;
    }
}