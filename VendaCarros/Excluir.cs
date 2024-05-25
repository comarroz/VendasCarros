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
    public partial class Excluir : Form
    {
        Dao bd;
        public Excluir()
        {
            InitializeComponent();
            bd = new Dao();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }//Fim do botão CPF

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                long cpf = Convert.ToInt64(textBox1.Text);// Coletando o cpf
                MessageBox.Show(bd.Excluir(cpf, "pessoa"));

                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado\n\n" + ex);
            }

        }//fim do botão Ecluir

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }//Fim do botão Cancelar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim do espaço cpf
    }
}
