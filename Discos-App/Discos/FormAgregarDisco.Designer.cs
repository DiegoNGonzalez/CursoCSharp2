namespace Discos
{
    partial class FormAgregarDisco
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.dTimeFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.cBoxEstilo = new System.Windows.Forms.ComboBox();
            this.cBoxEdicion = new System.Windows.Forms.ComboBox();
            this.numCantCanciones = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pBoxTapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre Disco:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(100, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha Lanzamiento";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(10, 135);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(102, 13);
            this.lblCantCanciones.TabIndex = 11;
            this.lblCantCanciones.Text = "Cantidad Canciones";
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(118, 175);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImg.TabIndex = 3;
            this.txtUrlImg.Leave += new System.EventHandler(this.txtUrlImg_Leave);
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Location = new System.Drawing.Point(26, 175);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(86, 13);
            this.lblUrlImg.TabIndex = 12;
            this.lblUrlImg.Text = "Url Imagen Tapa";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(80, 220);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 13;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(31, 273);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEdicion.TabIndex = 0;
            this.lblTipoEdicion.Text = "Tipo de Edición";
            // 
            // dTimeFechaLanzamiento
            // 
            this.dTimeFechaLanzamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFechaLanzamiento.Location = new System.Drawing.Point(118, 85);
            this.dTimeFechaLanzamiento.Name = "dTimeFechaLanzamiento";
            this.dTimeFechaLanzamiento.Size = new System.Drawing.Size(100, 20);
            this.dTimeFechaLanzamiento.TabIndex = 1;
            // 
            // cBoxEstilo
            // 
            this.cBoxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEstilo.FormattingEnabled = true;
            this.cBoxEstilo.Location = new System.Drawing.Point(118, 220);
            this.cBoxEstilo.Name = "cBoxEstilo";
            this.cBoxEstilo.Size = new System.Drawing.Size(100, 21);
            this.cBoxEstilo.TabIndex = 4;
            // 
            // cBoxEdicion
            // 
            this.cBoxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEdicion.FormattingEnabled = true;
            this.cBoxEdicion.Location = new System.Drawing.Point(118, 273);
            this.cBoxEdicion.Name = "cBoxEdicion";
            this.cBoxEdicion.Size = new System.Drawing.Size(100, 21);
            this.cBoxEdicion.TabIndex = 5;
            // 
            // numCantCanciones
            // 
            this.numCantCanciones.Location = new System.Drawing.Point(118, 135);
            this.numCantCanciones.Name = "numCantCanciones";
            this.numCantCanciones.Size = new System.Drawing.Size(100, 20);
            this.numCantCanciones.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 344);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 344);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pBoxTapa
            // 
            this.pBoxTapa.Location = new System.Drawing.Point(284, 43);
            this.pBoxTapa.Name = "pBoxTapa";
            this.pBoxTapa.Size = new System.Drawing.Size(271, 254);
            this.pBoxTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTapa.TabIndex = 18;
            this.pBoxTapa.TabStop = false;
            // 
            // FormAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.pBoxTapa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.numCantCanciones);
            this.Controls.Add(this.cBoxEdicion);
            this.Controls.Add(this.cBoxEstilo);
            this.Controls.Add(this.dTimeFechaLanzamiento);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormAgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Agregar Disco";
            this.Load += new System.EventHandler(this.FormAgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.DateTimePicker dTimeFechaLanzamiento;
        private System.Windows.Forms.ComboBox cBoxEstilo;
        private System.Windows.Forms.ComboBox cBoxEdicion;
        private System.Windows.Forms.NumericUpDown numCantCanciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pBoxTapa;
    }
}