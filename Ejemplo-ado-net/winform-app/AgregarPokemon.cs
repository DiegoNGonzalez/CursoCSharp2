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
        private Pokemon pokemon=null;
        public AgregarPokemon()
        {
            InitializeComponent();
        }
        public AgregarPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pokemon aux = new Pokemon();
            PokemonNegocio negocio= new PokemonNegocio();
            try
            {
                if (pokemon==null)
                    pokemon = new Pokemon();
                
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre= txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.ImgUrl=txtUrlImg.Text;
                pokemon.Tipo = (Elemento)cBoxTipo.SelectedItem;
                pokemon.Debilidad=(Elemento)cBoxDebilidad.SelectedItem;

                if(pokemon.Id != 0)
                {
                    negocio.Modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado con exito");

                }


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
                cBoxTipo.ValueMember = "Id";
                cBoxTipo.DisplayMember= "Descripcion";
                cBoxDebilidad.DataSource = elementoNegocio.Listar();
                cBoxDebilidad.ValueMember = "Id";
                cBoxDebilidad.DisplayMember = "Descripcion";
                

                if(pokemon!=null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text= pokemon.Descripcion;
                    CargarImagen(pokemon.ImgUrl);
                    txtUrlImg.Text = pokemon.ImgUrl;
                    cBoxTipo.SelectedValue = pokemon.Tipo.Id;
                    cBoxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }

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
