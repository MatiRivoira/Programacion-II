using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSlack_02
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

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Clear();
            this.lstTabla.Items.Clear();
        }

        private void txtNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                for (int i = 0; i <= 10; i++)
                {
                    this.lstTabla.Items.Add(this.txtNumero.Text + " x " + i + "= " + int.Parse(this.txtNumero.Text) * i);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Salir?", "error", MessageBoxButtons.YesNo) == DialogResult.No) { 
                e.Cancel = true;
            }
            
        }
    }
}
