using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSlack_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.groupBox1.Text = "Informacion";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int valorIngresado = int.Parse(this.textBox1.Text);
            int descuento = 0;

            if (valorIngresado > 5000)
            {
                descuento = valorIngresado * 20 / 100;
            }
            else if (valorIngresado > 3000)
            {
                descuento = valorIngresado * 10 / 100;
            }
            this.txtDescuento.Text = descuento.ToString();
            this.txtTotal.Text = (valorIngresado - descuento).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.txtDescuento.Clear();
            this.txtTotal.Clear();
        }
    }
}
