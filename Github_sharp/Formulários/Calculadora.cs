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
                case "*":
                    visorlbl.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case "/":
                    if (vNumAtual != 0)
                        visorlbl.Text = (vNumAnt / vNumAtual).ToString();
                    else
                        visorlbl.Text = "Erro";
                    break;
                case "^":
                    visorlbl.Text = Math.Pow((double)vNumAnt, (double)vNumAtual).ToString();
                    break;
            }
            lblHistorico.Text += vNumAtual + " = ";
            visorlbl.Focus();
            vLimparVisor = true;
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
            visorlbl.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (visorlbl.Text.Length > 1)
            {
                visorlbl.Text = visorlbl.Text.Substring(0, visorlbl.Text.Length - 1);
            }
            else
            {
                visorlbl.Text = "0";
            }
        }

        private void visorlbl_Click(object sender, EventArgs e)
        {

        }
        private void Calculadora_keydown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
   
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                string numero;

                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                    numero = (e.KeyCode - Keys.D0).ToString();
                else
                    numero = (e.KeyCode - Keys.NumPad0).ToString();

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl is Button b && b.Text == numero)
                    {
                        b.BackColor = Color.Gray;
                        f_digitos(b, EventArgs.Empty); // usa o botão real
                        break;
                    }
                }
            }

            // Operações
            switch (e.KeyCode)
            {
                case Keys.Add:
                case Keys.Oemplus:
                    ExecutarOperacao("+");
                    break;

                case Keys.Subtract:
                case Keys.OemMinus:
                    ExecutarOperacao("-");
                    break;

                case Keys.Multiply:
                    ExecutarOperacao("*");
                    break;

                case Keys.Divide:
                    ExecutarOperacao("/");
                    break;

                case Keys.Enter:
                    btnIgual_Click(null, EventArgs.Empty);
                    break;

                case Keys.Back:
                    btnBack_Click(null, EventArgs.Empty);
                    break;

                case Keys.Decimal:
                case Keys.Oemcomma:
                    virgulabtn_Click(null, EventArgs.Empty);
                    break;
                case Keys.Oem6: // tecla ^
                    ExecutarOperacao("^");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void lblCE_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_keyup(object sender, KeyEventArgs e)
        {
            foreach (Control botao in panel1.Controls)
            {
                botao.BackColor = Color.White;
            }
        }

        private void trocabtn_Click(object sender, EventArgs e)
        {
            if (visorlbl.Text != "0")
            {
                decimal valor = decimal.Parse(visorlbl.Text);
                visorlbl.Text = (-valor).ToString();
            }
        }
        private void ExecutarOperacao(string op)
        {
            vNumAnt = decimal.Parse(visorlbl.Text);
            vOperacao = op;
            vLimparVisor = true;

            lblHistorico.Text = vNumAnt + " " + vOperacao + " ";
        }
    }
}