using Margun.Model;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace Margun.Controller
{
    public partial class EstoqueController
    {
        EstoqueModel model = new EstoqueModel();

        #region ControllerEstoque
        public void AbrirFormulario<MiForm>(Panel panel) where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel.Controls.Add(formulario);
                panel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public void PegaRegistroEstoque(string produtoEstoque, int quantidadeEstoque,
                                          string tamanhoEstoque, decimal valorCompraEstoque, decimal valorVendaEstoque)
        {
            int ativo;
            string statusEstoque;

            ativo = 1;
            statusEstoque = "Estoque";

            model.CadastrarProduto(produtoEstoque, tamanhoEstoque, 
                                    quantidadeEstoque, valorCompraEstoque,valorVendaEstoque, 
                                    statusEstoque, ativo);
         }
        public DataTable ExibeEstoque()
        {
            DataTable table = new DataTable();

            table = model.MostrarEstoque();

            return table;
        }
        public void EditarEstoque(int codigoEstoque, string produtoEstoque, int quantidadeEstoque,
                                    string tamanhoEstoque, decimal valorCompraEstoque, decimal valorVendaEstoque)
        {
           model.EditEstoque(codigoEstoque, produtoEstoque, quantidadeEstoque,tamanhoEstoque,valorCompraEstoque, valorVendaEstoque);
        }
        public void ExcluirItemEstoque(int codigoEstoque)
        {
            int ativo = 0;

            model.ExcluirEstoque(codigoEstoque, ativo);
        }
        public DataTable PesquisaEstoque(string busca)
        {
            string aux;

            DataTable table = new DataTable();
            //aux = "%" + busca + "%";
            table = model.PesquisaEstoque(busca);

            return table;
        }
        #endregion
        #region ExecutaRelatorio
        public void ExRelatorio()
        {
            model.ExecutaRelatorio();
        }
        #endregion
    }
}
