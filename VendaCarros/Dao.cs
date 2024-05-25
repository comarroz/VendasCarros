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

        public string inserir(long cpf, string nome, string telefone, string endereco)
        {
            string inserir = $"Insert" +
                $" into pessoa(cpf, nome, telefone, endereco) values ('{cpf}','{nome}','{telefone}','{endereco}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + "Executado!";
            return resultado;

        }// fim do metodo

        public void preencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar
            this.cpf = new long[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];


            // Fazer o comando de seleção do banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //leitor do banco
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cpf[i] = Convert.ToInt64(leitura["cpf"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++; // percorrer o vetor
                contador++; // Contar quantos dados eu tenho 
            }//fim do while

            //encerro a comunicação com o software
            leitura.Close();
        }//Fim do Preencher

        //Criar o método para retornar o contador

        public int QuantidadedeDados()
        {
            return contador;
        }// Fim do quantidade de dados

        public string Atualizar(long cpf, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where cpf = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }//Fim do método

        public string Excluir(long cpf, string nomeTabela)
        {
            string query = $"DELETE FROM {nomeTabela} where CPF = '{cpf}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Excluido!";
            return resultado;
        }//fim do excluir 

    }// fim da classe





}//Fim do projeto
