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
    public partial class Form1 : Form
    {
       // Cadastar cad;
       // Consulta con;
       // Atualizar atu;
      //  Excluir exc;
        Opcoes opc;

        public Form1()
        {
            InitializeComponent();
            opc = new Opcoes();
            // con = new Consulta();
            // atu = new Atualizar();
            // exc = new Excluir();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            opc.ShowDialog();

        }//fim do botão opções

    }      

}


 