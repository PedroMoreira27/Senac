using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double v1 = 0, v2 = 0, count = 0;

            v1 = Convert.ToDouble(txtNumero1.Text);
            v2 = Convert.ToDouble(txtNumero2.Text);
            if (btnMaior.Checked == true)
            {
                if (v1 > v2)
                {
                    lblResultado.Text = v1 + " É o maior numero";
                }
                else if (v2 > v1)
                {
                    lblResultado.Text = v2 + " É o maior numero";
                }
                else
                {
                    lblResultado.Text = v2 + "e" + v1 + "São iguais";
                }
            }



            else if (btnDif.Checked == true)
            {
                lblResDiferenca.Text = "" + (v1 - v2);
            }



            else if (btnEntre.Checked == true)
            {
                count = 0;
                lblResEntre.Text += "";

                for (count = v1 + 1; count < v2; count++)
                {
                    lblResEntre.Text += "" + count;
                }
                for (count = v1 + 1; count > v2; count++)
                {
                    lblResEntre.Text += "" + count;
                }
            }
            else
            {
                lblResEntre.Text = "selecione uma opção";
            }

            }

        private void btnMaior_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
