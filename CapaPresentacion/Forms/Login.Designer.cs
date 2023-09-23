namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.labelIngresoUsuario = new System.Windows.Forms.Label();
            this.labelIngresoContrasenia = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.tlpDatosUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(690, 47);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(237, 51);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "Bienvenido";
            // 
            // labelIngresoUsuario
            // 
            this.labelIngresoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoUsuario.AutoSize = true;
            this.labelIngresoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoUsuario.Location = new System.Drawing.Point(3, 68);
            this.labelIngresoUsuario.Name = "labelIngresoUsuario";
            this.labelIngresoUsuario.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoUsuario.TabIndex = 2;
            this.labelIngresoUsuario.Text = "Ingrese su nombre de usuario:";
            // 
            // labelIngresoContrasenia
            // 
            this.labelIngresoContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIngresoContrasenia.AutoSize = true;
            this.labelIngresoContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresoContrasenia.Location = new System.Drawing.Point(3, 241);
            this.labelIngresoContrasenia.Name = "labelIngresoContrasenia";
            this.labelIngresoContrasenia.Size = new System.Drawing.Size(464, 37);
            this.labelIngresoContrasenia.TabIndex = 3;
            this.labelIngresoContrasenia.Text = "Ingrese su contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(470, 64);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(1040, 44);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasenia.Location = new System.Drawing.Point(470, 237);
            this.textBoxContrasenia.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(1040, 44);
            this.textBoxContrasenia.TabIndex = 1;
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.Location = new System.Drawing.Point(467, 609);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(686, 74);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // tlpDatosUsuario
            // 
            this.tlpDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDatosUsuario.ColumnCount = 2;
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17323F));
            this.tlpDatosUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82677F));
            this.tlpDatosUsuario.Controls.Add(this.textBoxContrasenia, 1, 1);
            this.tlpDatosUsuario.Controls.Add(this.textBoxUsuario, 1, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoUsuario, 0, 0);
            this.tlpDatosUsuario.Controls.Add(this.labelIngresoContrasenia, 0, 1);
            this.tlpDatosUsuario.Location = new System.Drawing.Point(33, 182);
            this.tlpDatosUsuario.Name = "tlpDatosUsuario";
            this.tlpDatosUsuario.RowCount = 2;
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDatosUsuario.Size = new System.Drawing.Size(1510, 346);
            this.tlpDatosUsuario.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.tlpDatosUsuario);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelBienvenido);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tlpDatosUsuario.ResumeLayout(false);
            this.tlpDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Label labelIngresoUsuario;
        private System.Windows.Forms.Label labelIngresoContrasenia;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.TableLayoutPanel tlpDatosUsuario;
    }
}

