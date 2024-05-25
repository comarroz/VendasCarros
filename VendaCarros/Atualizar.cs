using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendaCarros
{
    public partial class Atualizar : Form
    {
        Dao bd;
        public Atualizar()
        {
            InitializeComponent();
            bd = new Dao();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }//fim do bpotão Dado

        private void button1_Click(object sender, EventArgs e)
        {

        }//Fim do Botão CPF

        private void button2_Click(object sender, EventArgs e)
        {

        }//Fim do botão Campo

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                string campo = textBox2.Text;
                string dado = textBox3.Text;
                //Atualizar os daos
                MessageBox.Show(bd.Atualizar(cpf, "pessoa", campo, dado));
                //Limpar os dados

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado\n\n" + ex);
            }
        }//Fim do BOTÂO Atualizar

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Fim do Botão Cancelar 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// fim do espaço cpf

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fim do espaço campo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// fim do espaço dado
    }
}
