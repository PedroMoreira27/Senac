using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double v1 = 0, v2 = 0, r = 0;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor1.Text);
            if (rdbSomar.Checked == true)
            {
                r = (v1 + v2);
            }
            else if (rdbSubtrair.Checked == true)
            {
                r = (v1 - v2);
            }
            else if (rdbDividir.Checked == true)
            {
                r = (v1 / v2);
            }
            else if (rdbMultiplicar.Checked == true)
            {
                r = (v1 * v2);
            }
            else
            {

                MessageBox.Show("Teste", "Selecione uma operação.");
            }

            lblResultado.Text = "" + r;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Não_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
