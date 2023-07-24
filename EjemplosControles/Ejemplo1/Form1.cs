using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elemento = txtNombre.Text;
            elementos.Items.Add(elemento);
            txtNombre.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Celeste");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento= dtpFechaDeNacimiento.Value;
            //operardor ternario
            string chocolate = chbChocolate.Checked==true?"Le gusta el chocolate":"No le gusta el chocolate...";

            string tipo;
            if (rbtnMuggle.Checked)
                tipo = "Muggle";
            else if (rbtnWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string color = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito= numFavorito.Value.ToString();
            elementos.Items.Add(nombre);
            elementos.Items.Add(chocolate);
            elementos.Items.Add(tipo);
            elementos.Items.Add(color);
            elementos.Items.Add(numeroFavorito);

        }
    }
}
