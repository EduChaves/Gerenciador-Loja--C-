using Margun.Model;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margun.Controller
{
    public partial class CaixaController
    {
        CaixaModel caixaModel = new CaixaModel();

        public DataTable BuscaProduto(int codigoProduto)
        {
            DataTable table = new DataTable();
            table = caixaModel.BustaItem(codigoProduto);

            return table;
        }
        public void AddCarrinho(int codigo, string produto, int quantidade, string tamanho, decimal valor)
        {
            caixaModel.AddCarrinho(codigo, produto, quantidade, tamanho, valor);
        }
        public DataTable ExibeCarrinho()
        {
            DataTable table = new DataTable();

            table = caixaModel.MostraCarrinho();

            return table;
        }
       
    }
}
