using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSlack_04
{
    public partial class Form1 : Form
    {
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.txtNumero.Text);
            this.contador++;
            this.txtNumero.Clear();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contador; i++) {
                for (int j = i + 1; j < contador; j++) {
                    if (this.rbtnAscendente.Checked == true){
                        if (int.Parse(this.listBox1.Items[i].ToString()) > int.Parse(this.listBox1.Items[j].ToString()))
                        {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;
                        }
                    } else {
                        if (int.Parse(this.listBox1.Items[i].ToString()) < int.Parse(this.listBox1.Items[j].ToString())) {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.contador = 0;
            this.listBox1.Items.Clear();
        }
    }
}
