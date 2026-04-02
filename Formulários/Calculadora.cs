using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Github_csharp.Formulários
{
    public partial class Calculadora : Form
    {
        decimal vNumAnt;
        string vOperacao;
        bool vLimparVisor;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (visorlbl.Text == "0" || vLimparVisor)
            {
                visorlbl.Text = "";
                vLimparVisor = false;
            }
            visorlbl.Text += digito;
            this.ActiveControl = null;

        }
        private void f_operacoes(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(visorlbl.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
            lblHistorico.Text = "";
            lblHistorico.Text = vNumAnt + " " + vOperacao + " ";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //pegar o numero decimal do vetor
            decimal vNumAtual = decimal.Parse(visorlbl.Text);
            //decidir que operação realizar
            switch (vOperacao)
            {
                case "+":
                    visorlbl.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    visorlbl.Text = (vNumAnt - vNumAtual).ToString();
                    break;
            }
            lblHistorico.Text += vNumAtual + " = ";
            visorlbl.Focus();
        }

        private void virgulabtn_Click(object sender, EventArgs e)
        {
            if (!visorlbl.Text.Contains(","))
            {
                visorlbl.Text += ",";

            }
            visorlbl.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            visorlbl.Text = " ";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            visorlbl.Text = visorlbl.Text.Substring(0, visorlbl.Text.Length -);
            if (visorlbl.Text == "") visorlbl.Text = "0";
        }

        private void visorlbl_Click(object sender, EventArgs e)
        {

        }
        private void Calculadora_keydown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            Button botao = new Button();
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                f_digitos(botao, e);
            }
        }
    }
}