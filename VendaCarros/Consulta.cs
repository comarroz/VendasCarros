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
     
    public partial class Consulta : Form
    {
        Dao bd;
        Consulta con;
        public Consulta()
        {
            InitializeComponent();
            bd = new Dao();

            
            ConfigurarGrid();// Estruturar o grid
            NomesDados(); // dar os nomes as colunas 
            bd.preencherVetor();// Comsulto o banco de dados
            AdicionarDados(); // Inserir linhas na tela
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void NomesDados()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }// Fim do método

        public void AdicionarDados()
        {
            for (int i = 0; i < bd.QuantidadedeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.cpf[i], bd.nome[i], bd.telefone[i], bd.endereco[i]);
            }
        }// fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false; // usuario não adiciona linhas
            dataGridView1.AllowUserToDeleteRows = false; // usuario não apaga linhas
            dataGridView1.AllowUserToResizeColumns = false; //usuario não adiciona colunas
            dataGridView1.AllowUserToResizeRows = false;// Usuario modificar linhas
            dataGridView1.ColumnCount = 4; // Quantidade de colun
        }// fi do método

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }// fim do botão Voltar 
    }
}
