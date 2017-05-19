using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleicao_dos_Goleiros
{
    public partial class urnavotacao : Form
    {
        int votos = 0, rogerio = 0, cassio = 0, prass = 0, wanderlei =0 ;
        public urnavotacao()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void urnavotacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            painel.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            painel.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            painel.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painel.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            painel.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            painel.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            painel.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            painel.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            painel.AppendText("9");
        }

        private void lblres_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = ("Rogério:" + rogerio + "\n Prass: " + prass + "\n Cassio: " + cassio + "\nWanderlei: " + wanderlei);
            DialogResult dialogResult = MessageBox.Show("Voto computado com sucesso!");
            if (dialogResult == DialogResult.Yes) ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            painel.AppendText("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            painel.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("oi");
            //if (dialogResult == DialogResult.Yes);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            votos = Convert.ToInt16(painel.Text);
            
            switch (votos)
            {
                case 10:
                        cassio++;
                    lblres.Text = ("Nome: Cassio\n Time: Corinthians");
                    pResultado.Image = Properties.Resources.Cassio;
                        break;
                case 15:
                        rogerio++;
                    lblres.Text = ("Nome: Rogério\n Time: São Paulo");
                    pResultado.Image = Properties.Resources.Rogerio;
                    break;
                case 20:
                    prass++;
                    lblres.Text = ("Nome: Prass\n Time: Palmeiras");
                    pResultado.Image = Properties.Resources.Prass;
                    break;
                case 25:
                    wanderlei++;
                    lblres.Text = ("Nome: Vanderlei\n Time: Santos");
                    pResultado.Image = Properties.Resources.Wanderlei;
                    break;
            }
        }
    }
}
