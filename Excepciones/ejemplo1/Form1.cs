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
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);

                r = a + b;
                label1.Text = "= " + r;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al ejecutar, intente nuevamente");
            }
        }
    }
}
