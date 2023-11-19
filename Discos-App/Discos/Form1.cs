using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Discos
{
    public partial class Discos_DB : Form
    {
        private List<Disco> listaDiscos;
        public Discos_DB()
        {
            InitializeComponent();
        }

        private void Discos_DB_Load(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            listaDiscos = negocio.Listar();
            dgvDiscos.DataSource = listaDiscos;
             dgvDiscos.Columns["UrlImgTapa"].Visible = false;
            CargarImagen(listaDiscos[0].UrlImgTapa);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                picBoxTapa.Load(imagen);
            }
            catch (Exception ex)
            {

                picBoxTapa.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImgTapa);
        }
    }
}
