using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            inserirDado();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string m = "";
            if (cmbTexto.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione uma opção da lista.");
            }
            else
            {
                m = cmbTexto.SelectedItem.ToString();
                MessageBox.Show("Selecionado: " + m);
            }
        }

        private void txtInserir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                // MessageBox.Show("Você acaba de pressionar a tecla ENTER!");
                inserirDado();
            }
        }

        private void inserirDado()
        {
            if (txtInserir.Text == "")
            {
                MessageBox.Show("Informe um valor na caixa");
                txtInserir.Focus();
            }
            else
            {
                cmbTexto.Items.Add(txtInserir.Text);
                MessageBox.Show("Dado inserido");
                txtInserir.Text = "";
                txtInserir.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            string arg = "C:/Users/pedro.gmoreira1/Downloads/fonte1.jfif";
            ptbImagem.Image = Image.FromFile(arg);
        }

        private void cmbTexto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInserir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
