using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Margun.Model
{
    public class EstoqueModel
    {
        #region EstoqueCRUD
        public void CadastrarProduto(string produtoEstoque, string tamanhoEstoque,
                                     int quantidadeEstoque, decimal valorCompraEstoque, decimal valorVendaEstoque,
                                     string statusEstoque, int ativo)
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "INSERT INTO estoque (produtoEstoque, quantidadeEstoque, tamanhoEstoque," +
                                            " valorCompraEstoque, valorVendaEstoque, statusEstoque, ativo)" +
                         "VALUES (@produto, @quantidade, @tamanho, @valorCompra, @valorVenda, @status, @ativo)";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                comando.Parameters.AddWithValue("@produto", produtoEstoque);
                comando.Parameters.AddWithValue("@quantidade", quantidadeEstoque);
                comando.Parameters.AddWithValue("@tamanho", tamanhoEstoque);
                comando.Parameters.AddWithValue("@valorCompra", valorCompraEstoque);
                comando.Parameters.AddWithValue("@valorVenda", valorVendaEstoque);
                comando.Parameters.AddWithValue("@status", statusEstoque);
                comando.Parameters.AddWithValue("@ativo", ativo);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                conexao = null;
                comando = null;

                Console.Write("Cadastro Realizado com Sucesso!!");
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }  
        }
        public DataTable MostrarEstoque()
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "SELECT * FROM estoque WHERE ativo=1";

                MySqlDataAdapter data = new MySqlDataAdapter(query, conexao);
                DataTable table = new DataTable();

                data.Fill(table);

                return table;

                conexao.Close();
                conexao = null;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public void EditEstoque(int codigoEstoque, string produtoEstoque, int quantidadeEstoque,
                                  string tamanhoEstoque, decimal valorCompraEstoque, decimal valorVendaEstoque)
        {
            string query;
           try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "UPDATE estoque SET produtoEstoque=@produto, quantidadeEstoque=@quantidade, tamanhoEstoque=@tamanho," +
                                             "valorCompraEstoque=@valorCompra, valorVendaEstoque=@valorVenda WHERE codigoEstoque=@codigo";

                MySqlCommand comando = new MySqlCommand(query,conexao);

                comando.Parameters.AddWithValue("@produto", produtoEstoque);
                comando.Parameters.AddWithValue("@quantidade", quantidadeEstoque);
                comando.Parameters.AddWithValue("@tamanho", tamanhoEstoque);
                comando.Parameters.AddWithValue("@valorCompra", valorCompraEstoque);
                comando.Parameters.AddWithValue("@valorVenda", valorVendaEstoque);
                comando.Parameters.AddWithValue("@codigo", codigoEstoque);

                conexao.Open();
                comando.ExecuteNonQuery();

                Console.Write("Produto Alterado com Sucesso!");

                conexao.Close();
                conexao = null;
                comando = null;
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        public void ExcluirEstoque(int codigoEstoque, int ativo)
        {
            string query;
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "UPDATE estoque SET ativo=@ativo WHERE codigoEstoque=@codigo";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@ativo", ativo);
                comando.Parameters.AddWithValue("@codigo", codigoEstoque);

                conexao.Open();
                comando.ExecuteNonQuery();

                Console.Write("Item desativado com sucesso");
                conexao.Close();
                conexao = null;
                comando = null;
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        public DataTable PesquisaEstoque(string busca)
        {
            string query;
            try
            {
                Console.WriteLine("Iniciando busca...");
                MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=margun;Uid=root;Pwd=;");

                query = "SELECT * FROM estoque WHERE produtoEstoque LIKE '%"+ busca +"%'";// WHERE produtoEstoqueLIKE '%@produto%'";

                DataTable table = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(query,conexao);
                
                conexao.Open();
                Console.WriteLine("Passou");

                data.Fill(table);

                return table;
                Console.WriteLine("Encontrado");

                conexao.Close();
                conexao = null;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        #endregion
        #region RelatorioEstoque
         public string ExecutaRelatorio()
        {
            string codigo, ativo, quantidade;
            string produto, tamanho, status;
            string valorCompra, ValorVenda;
            int linha = 0;
            string filepath = @"C:\Users\edurd\Documents\Visual Studio 2015\Projects\Margun\temp\RelatorioEstoque.xlsx";

            DataTable table = new DataTable();
            Excel.Application excelapp;
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;

            excelapp = new Excel.Application();
            excelapp.Visible = false;
            
            workbook = excelapp.Workbooks.Open(filepath);

            worksheet = workbook.Worksheets[1];

            Console.WriteLine("Executando Relatorio...");

            linha = 5;

            worksheet.Cells.Range["A" + linha.ToString()].Value = "Cod";
            worksheet.Cells.Range["B" + linha.ToString()].Value = "Produto";
            worksheet.Cells.Range["C" + linha.ToString()].Value = "Qtde";
            worksheet.Cells.Range["D" + linha.ToString()].Value = "Tamanho";
            worksheet.Cells.Range["E" + linha.ToString()].Value = "Valor Compra";
            worksheet.Cells.Range["F" + linha.ToString()].Value = "Valor Venda";
            worksheet.Cells.Range["G" + linha.ToString()].Value = "Status";
            worksheet.Cells.Range["H" + linha.ToString()].Value = "Ativo";

            linha = 6;

            try
             {
                 table = MostrarEstoque();

                 for(int i = 0; i < table.Rows.Count; i++)
                 {
                    Console.WriteLine("teste");
                    codigo = table.Rows[i][0].ToString();
                    produto = table.Rows[i][1].ToString();
                    quantidade = table.Rows[i][2].ToString();
                    tamanho = table.Rows[i][3].ToString();
                    valorCompra = table.Rows[i][4].ToString();
                    ValorVenda = table.Rows[i][5].ToString();
                    status = table.Rows[i][6].ToString();
                    ativo = table.Rows[i][7].ToString();

                    Console.WriteLine(codigo);
                    Console.WriteLine(produto);
                    Console.WriteLine(quantidade);
                    Console.WriteLine(tamanho);
                    Console.WriteLine(valorCompra);
                    Console.WriteLine(ValorVenda);
                    Console.WriteLine(status);
                    Console.WriteLine(ativo);

                    worksheet.Cells.Range["A" + linha.ToString()].Value = codigo;
                    worksheet.Cells.Range["B" + linha.ToString()].Value = produto;
                    worksheet.Cells.Range["C" + linha.ToString()].Value = quantidade;
                    worksheet.Cells.Range["D" + linha.ToString()].Value = tamanho;
                    worksheet.Cells.Range["E" + linha.ToString()].Value = valorCompra;
                    worksheet.Cells.Range["F" + linha.ToString()].Value = ValorVenda;
                    worksheet.Cells.Range["G" + linha.ToString()].Value = status;
                    worksheet.Cells.Range["H" + linha.ToString()].Value = ativo;

                     linha++;
                 }
             }
             catch(Exception ex)
             {
                 Console.WriteLine(ex.Message);
                Console.WriteLine("TESTETSTETS");
                 workbook.Close(false);
                 excelapp.Quit();

                 Marshal.ReleaseComObject(workbook);
                 Marshal.ReleaseComObject(excelapp);

                 workbook = null;
                 excelapp = null;
             }
            workbook.SaveAs(@"c:\MargunRelatorio\RelatorioEstoque.xlsx");

            Console.WriteLine("Success!!");
            excelapp.Visible = true;

            workbook.Close(false);
            excelapp.Quit();

            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelapp);

            workbook = null;
            excelapp = null;
            return null;
        }
        #endregion
    }
}
