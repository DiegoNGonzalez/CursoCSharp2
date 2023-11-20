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

namespace Discos
{
    public partial class FormAgregarDisco : Form
    {
        public FormAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Disco aux = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                aux.NombreDisco= txtNombre.Text;
                aux.FechaLanzamiento = dTimeFechaLanzamiento.Value;
                aux.CantidadCanciones= (int)numCantCanciones.Value;
                aux.UrlImgTapa=txtUrlImg.Text;
                aux.estilo = (Estilo)cBoxEstilo.SelectedItem;
                aux.tipoEdicion=(TipoEdicion)cBoxEdicion.SelectedItem;
                negocio.AgregarDisco(aux);
                MessageBox.Show("Agregado con exito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void FormAgregarDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio= new EdicionNegocio();
            try
            {
                cBoxEstilo.DataSource = estiloNegocio.Listar();
                cBoxEdicion.DataSource= edicionNegocio.Listar();
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
                pBoxTapa.Load(imagen);
            }
            catch (Exception ex)
            {

                pBoxTapa.Load("https://www.pngkey.com/png/detail/233-2332677_ega-png.png");
            }
        }
    }
}
