using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//Importar o MySQL


namespace VendaCarros
{
    internal class Dao
    {
        public MySqlConnection conexao;
        public long[] cpf;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;
        //public string[] opcao;
       // public string[] pesquisar;


        public Dao()
        {

            conexao = new MySqlConnection("server=localhost;Database=VendaCarros;Uid=root;password=");
            try
            {
                conexao.Open();// Abrir a conexão


            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado! \n\n" + ex);

            }

        }//Fim do Contrutor
    }

      



}//Fim do projeto
