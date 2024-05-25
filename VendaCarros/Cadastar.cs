using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendaCarros
{
    public partial class Cadastar : Form

    {
        Dao bd;

        public Cadastar()
        {
            InitializeComponent();
            bd = new Dao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Fim do Botão Cancelar

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim do Botão CPF

        private void label2_Click(object sender, EventArgs e)
        {

        }//Fim do botão Nome

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim do botão Telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }//Fim do botão endereço

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);
                string nome = textBox2.Text;
                string telefone = textBox3.Text;
                string endereco = textBox4.Text;
                MessageBox.Show(bd.inserir(cpf, nome, telefone, endereco));//Insere dados no BD
                                                                           //Limpar a tela
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado!\n\n" + ex);
            }



        }//Fim do botão Cadastrar

        private void Cadastar_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do Botão CPF

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// fi do nome 

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }// Fim do telefone 

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do enderço
    }
}
