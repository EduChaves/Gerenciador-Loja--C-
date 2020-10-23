using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Margun.Model
{
    public class CaixaModel
    {
        #region CaixaCRUD
        public DataTable BustaItem(int codigoProduto)
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "SELECT * FROM estoque WHERE ativo=1 AND codigoEstoque=" + codigoProduto;

                DataTable table = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(query, conexao);

                conexao.Open();
                data.Fill(table);
                                
                return table;

                conexao.Close();
                conexao = null;                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Passei");
                return null;
            }
           
        }
        public void AddCarrinho(int codigo, string produto, int quantidade, string tamanho, decimal valor)
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "INSERT INTO carrinho(codigo, produtoCarrinho, quantidadeCarrinho, valorCarrinho, tamanhoCarrinho) " +
                        "VALUES(@codigo, @produto, @quantidade, @valor, @tamanho)";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@produto", produto);
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@valor", valor);
                comando.Parameters.AddWithValue("@tamanho", tamanho);

                conexao.Open();
                comando.ExecuteNonQuery();

                Console.WriteLine("Produto Inserido no Carrinho");

                conexao.Close();
                conexao = null;
                comando = null;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public DataTable MostraCarrinho()
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "SELECT * FROM carrinho";

                MySqlDataAdapter data = new MySqlDataAdapter(query, conexao);
                DataTable table = new DataTable();

                conexao.Open();
                data.Fill(table);

                return table;

                conexao.Close();
                conexao = null;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion
    }
}
