using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1_CalcularelIVAdeunProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
                
        {
            double iva, valorf;
            double precioproducto = double.Parse(txt_valorp.Text);
            if (txt_valorp.Text == "")
            {
                MessageBox.Show("El campo valor del producto esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_valorp.Focus();
            }
            else
            {
                

                iva = precioproducto * 0.19;
                valorf = precioproducto + iva;

                lbl_valoriva.Text = Convert.ToString("$" + String.Format("{0:n0}", iva));
                lbl_valorfinal.Text = Convert.ToString("$" + String.Format("{0:n0}", valorf));

                label3.Visible = true;
                label4.Visible = true;
                lbl_valoriva.Visible = true;
                lbl_valorfinal.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_valorp.Text = String.Empty;
            label3.Visible = false;
            label4.Visible = false;
            lbl_valoriva.Visible = false;
            lbl_valorfinal.Visible = false;
            txt_valorp.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
