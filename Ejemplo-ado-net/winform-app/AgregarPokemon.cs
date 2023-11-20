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
                aux.Tipo = (Elemento)cBoxTipo.SelectedItem;
                aux.Debilidad=(Elemento)cBoxDebilidad.SelectedItem;
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

        private void AgregarPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cBoxTipo.DataSource = elementoNegocio.Listar();
                cBoxDebilidad.DataSource = elementoNegocio.Listar(); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
           CargarImagen(txtUrlImg.Text);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {

                picBoxPokemon.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
            }
        }
    }
}
