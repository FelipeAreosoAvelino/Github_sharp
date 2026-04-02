using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Github_csharp.Formulários
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void cálculosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comRadioButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Calculadora_radio == null || Calculadora_radio.IsDisposed)
            {
                Calculadora_radio = new Calc_radio_buttons();
                Calculadora_radio.Show();

            }
            else
            {
                Calculadora_radio.BringToFront();
            }
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Calculadora_buttons == null || Calculadora_buttons.IsDisposed)
            {
                Calculadora_buttons = new Form1();
                Calculadora_buttons.Show();

            }
            else
            {
                Calculadora_buttons.BringToFront();
            }
        }
        
        private Form1 Calculadora_buttons;

        private Calc_radio_buttons Calculadora_radio;

        private Calculadora Calculadora_visor;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }


        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;   
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stahora.Text = DateTime.Now.ToString();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void superCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Calculadora_visor == null || Calculadora_visor.IsDisposed)
            {
                Calculadora_visor = new Calculadora();
                Calculadora_visor.Show();

            }
            else
            {
                Calculadora_visor.BringToFront();
            }
        }
    }
}
