namespace CapaPresentacion.Forms
{
    partial class ControlAnimal
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
            this.buttonVolverControl = new System.Windows.Forms.Button();
            this.labelTituloControl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIngresarIdMascota = new System.Windows.Forms.Label();
            this.textBoxIngresarIdMascota = new System.Windows.Forms.TextBox();
            this.buttonBuscarMascota = new System.Windows.Forms.Button();
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolverControl
            // 
            this.buttonVolverControl.AutoSize = true;
            this.buttonVolverControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverControl.Location = new System.Drawing.Point(12, 813);
            this.buttonVolverControl.Name = "buttonVolverControl";
            this.buttonVolverControl.Size = new System.Drawing.Size(84, 36);
            this.buttonVolverControl.TabIndex = 0;
            this.buttonVolverControl.Text = "Volver";
            this.buttonVolverControl.UseVisualStyleBackColor = true;
            this.buttonVolverControl.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTituloControl
            // 
            this.labelTituloControl.AutoSize = true;
            this.labelTituloControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloControl.Location = new System.Drawing.Point(690, 47);
            this.labelTituloControl.Name = "labelTituloControl";
            this.labelTituloControl.Size = new System.Drawing.Size(405, 51);
            this.labelTituloControl.TabIndex = 1;
            this.labelTituloControl.Text = "Control de animales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.65313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.93388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.413F));
            this.tableLayoutPanel1.Controls.Add(this.labelIngresarIdMascota, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIngresarIdMascota, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuscarMascota, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 182);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1509, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelIngresarIdMascota
            // 
            this.labelIngresarIdMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresarIdMascota.AutoSize = true;
            this.labelIngresarIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarIdMascota.Location = new System.Drawing.Point(3, 31);
            this.labelIngresarIdMascota.Name = "labelIngresarIdMascota";
            this.labelIngresarIdMascota.Size = new System.Drawing.Size(532, 37);
            this.labelIngresarIdMascota.TabIndex = 0;
            this.labelIngresarIdMascota.Text = "Ingrese el ID de una mascota:";
            // 
            // textBoxIngresarIdMascota
            // 
            this.textBoxIngresarIdMascota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIngresarIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresarIdMascota.Location = new System.Drawing.Point(541, 28);
            this.textBoxIngresarIdMascota.Name = "textBoxIngresarIdMascota";
            this.textBoxIngresarIdMascota.Size = new System.Drawing.Size(687, 44);
            this.textBoxIngresarIdMascota.TabIndex = 1;
            // 
            // buttonBuscarMascota
            // 
            this.buttonBuscarMascota.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscarMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarMascota.Location = new System.Drawing.Point(1241, 28);
            this.buttonBuscarMascota.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.buttonBuscarMascota.Name = "buttonBuscarMascota";
            this.buttonBuscarMascota.Size = new System.Drawing.Size(258, 44);
            this.buttonBuscarMascota.TabIndex = 2;
            this.buttonBuscarMascota.Text = "Buscar";
            this.buttonBuscarMascota.UseVisualStyleBackColor = true;
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Location = new System.Drawing.Point(43, 321);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.ReadOnly = true;
            this.dgvAnimales.Size = new System.Drawing.Size(1489, 287);
            this.dgvAnimales.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.buttonIngresar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEditar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonEliminar, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(43, 614);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1489, 100);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonIngresar.AutoSize = true;
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(155, 3);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(185, 94);
            this.buttonIngresar.TabIndex = 0;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonEditar.AutoSize = true;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(651, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(185, 94);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonEliminar.AutoSize = true;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(1148, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(185, 94);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ControlAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvAnimales);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelTituloControl);
            this.Controls.Add(this.buttonVolverControl);
            this.Name = "ControlAnimal";
            this.Text = "ControlMascotas";
            this.Activated += new System.EventHandler(this.ControlAnimal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlMascotas_FormClosing);
            this.Load += new System.EventHandler(this.ControlAnimal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverControl;
        private System.Windows.Forms.Label labelTituloControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIngresarIdMascota;
        private System.Windows.Forms.TextBox textBoxIngresarIdMascota;
        private System.Windows.Forms.Button buttonBuscarMascota;
        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}