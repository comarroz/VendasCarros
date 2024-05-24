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
    public partial class Opcoes : Form
    {

        Cadastar cad;
        Consulta con;
        Atualizar atu;
        Excluir exc;
        public Opcoes()
        {
            InitializeComponent();
            cad = new Cadastar();
            con = new Consulta();
            atu = new Atualizar();
            exc = new Excluir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();

        }//Fim do botão Cadastar

        private void button2_Click(object sender, EventArgs e)
        {
            con.ShowDialog();

        }//Fim do botão Consultar

        private void button3_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();

        }//Fim do botão Atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();

        }//Fim do botão Excluir
    }
}
