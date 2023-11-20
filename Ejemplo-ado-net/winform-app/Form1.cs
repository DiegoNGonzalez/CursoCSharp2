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
    public partial class formPokedex : Form
    {
        private List<Pokemon> ListaPokemon;
       
        public formPokedex()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();

        }
        private void CargarGrid()
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                ListaPokemon = negocio.Listar();
                dgvPokemon.DataSource = ListaPokemon;
                dgvPokemon.Columns["Id"].Visible = false;
                dgvPokemon.Columns["ImgUrl"].Visible = false;
                CargarImagen(ListaPokemon[0].ImgUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
           Pokemon Seleccionado= (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.ImgUrl);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPokemon alta = new AgregarPokemon();
            alta.ShowDialog();
            CargarGrid();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            AgregarPokemon modificar= new AgregarPokemon(seleccionado);
            modificar.ShowDialog();
            CargarGrid();
        }
    }
}
