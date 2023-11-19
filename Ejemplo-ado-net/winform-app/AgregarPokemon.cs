using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace winform_app
{
    public partial class AgregarPokemon : Form
    {
        public AgregarPokemon()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pokemon aux = new Pokemon();
            PokemonNegocio negocio= new PokemonNegocio();
            try
            {
                aux.Numero = int.Parse(txtNumero.Text);
                aux.Nombre= txtNombre.Text;
                aux.Descripcion = txtDescripcion.Text;
                aux.ImgUrl=txtUrlImg.Text;
                negocio.Agregar(aux);
                MessageBox.Show("Agregado con exito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
