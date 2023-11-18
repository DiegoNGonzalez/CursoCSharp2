using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = Calcular();
                lbl1.Text = "= " + resultado;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error no reconocido... contactar a tu dev...");
            }
            finally
            {
                //instrucciones ... se van a ejecutar independientemente de si se ejecuto o no el try o el catch
                //operacion sensible...
                //apertura de db o archivos 

            }
            

        }

        private int Calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtN1.Text);
                b = int.Parse(txtN2.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                //guardar registro de error en archivo
                throw ex;
            }
        }
    }
}
