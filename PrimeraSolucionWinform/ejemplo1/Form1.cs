using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {//partial permite tener en pedazos la clase en una funcionalidad, en otra diseño
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("te doy la bienvenidaa");
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola "+txt1.Text);
            btnSaludar.Text ="saludado";


        }

        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txt1.Text= txtNombre.Text;
        }
    }
}
