namespace Ejemplo1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.elementos = new System.Windows.Forms.ListView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chbChocolate = new System.Windows.Forms.CheckBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.rbtnWizard = new System.Windows.Forms.RadioButton();
            this.rbtnMuggle = new System.Windows.Forms.RadioButton();
            this.rbtnSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.numFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(157, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(64, 414);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // elementos
            // 
            this.elementos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementos.HideSelection = false;
            this.elementos.Location = new System.Drawing.Point(113, 311);
            this.elementos.Name = "elementos";
            this.elementos.Size = new System.Drawing.Size(241, 97);
            this.elementos.TabIndex = 7;
            this.elementos.UseCompatibleStateImageBehavior = false;
            this.elementos.View = System.Windows.Forms.View.List;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(92, 63);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(50, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre: ";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(43, 95);
            this.labelFecha.MaximumSize = new System.Drawing.Size(200, 20);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(108, 13);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "Fecha de Nacimiento";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(157, 95);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaDeNacimiento.TabIndex = 1;
            // 
            // chbChocolate
            // 
            this.chbChocolate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbChocolate.AutoSize = true;
            this.chbChocolate.Location = new System.Drawing.Point(182, 129);
            this.chbChocolate.Name = "chbChocolate";
            this.chbChocolate.Size = new System.Drawing.Size(135, 17);
            this.chbChocolate.TabIndex = 2;
            this.chbChocolate.Text = "Te gusta el chocolate?";
            this.chbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(152, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(184, 31);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil Persona";
            // 
            // rbtnWizard
            // 
            this.rbtnWizard.AutoSize = true;
            this.rbtnWizard.Checked = true;
            this.rbtnWizard.Location = new System.Drawing.Point(34, 19);
            this.rbtnWizard.Name = "rbtnWizard";
            this.rbtnWizard.Size = new System.Drawing.Size(58, 17);
            this.rbtnWizard.TabIndex = 0;
            this.rbtnWizard.TabStop = true;
            this.rbtnWizard.Text = "Wizard";
            this.rbtnWizard.UseVisualStyleBackColor = true;
            // 
            // rbtnMuggle
            // 
            this.rbtnMuggle.AutoSize = true;
            this.rbtnMuggle.Location = new System.Drawing.Point(139, 19);
            this.rbtnMuggle.Name = "rbtnMuggle";
            this.rbtnMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtnMuggle.TabIndex = 10;
            this.rbtnMuggle.Text = "Muggle";
            this.rbtnMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtnSquibs
            // 
            this.rbtnSquibs.AutoSize = true;
            this.rbtnSquibs.Location = new System.Drawing.Point(251, 19);
            this.rbtnSquibs.Name = "rbtnSquibs";
            this.rbtnSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtnSquibs.TabIndex = 11;
            this.rbtnSquibs.Text = "Squibs";
            this.rbtnSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxTipo.Controls.Add(this.rbtnSquibs);
            this.gbxTipo.Controls.Add(this.rbtnWizard);
            this.gbxTipo.Controls.Add(this.rbtnMuggle);
            this.gbxTipo.Location = new System.Drawing.Point(70, 152);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(359, 46);
            this.gbxTipo.TabIndex = 3;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(157, 214);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(213, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(72, 222);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 14;
            this.lblColor.Text = "Color Favorito";
            // 
            // numFavorito
            // 
            this.numFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFavorito.Location = new System.Drawing.Point(157, 245);
            this.numFavorito.Name = "numFavorito";
            this.numFavorito.Size = new System.Drawing.Size(213, 20);
            this.numFavorito.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(79, 245);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Nro Favorito";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(67, 282);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 482);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.chbChocolate);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.elementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(724, 690);
            this.MinimumSize = new System.Drawing.Size(523, 521);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView elementos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.CheckBox chbChocolate;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.RadioButton rbtnWizard;
        private System.Windows.Forms.RadioButton rbtnMuggle;
        private System.Windows.Forms.RadioButton rbtnSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.NumericUpDown numFavorito;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

