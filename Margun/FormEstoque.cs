using Margun.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace Margun
{
    public partial class FormEstoque : Form
    {
        EstoqueController ctrll = new EstoqueController();

        public static bool is_salve = true;
        public FormEstoque()
        {
            InitializeComponent();
            ExibeEstoque();                     
        }
       
        #region ViewEstoque
        private void ExibeEstoque()
        {
            DataTable table = new DataTable();

            table = ctrll.ExibeEstoque();

            dataEstoque.DataSource = table;
        }
        private void btnNovoEstoque_Click(object sender, EventArgs e)
        {
            is_salve = true;

            txtProdutoEstoque.Enabled = true;
            txtQuantidadeEstoque.Enabled = true;
            txtValorCompraEstoque.Enabled = true;
            txtValorVendaEstoque.Enabled = true;
            cbTamanhoEstoque.Enabled = true;

            btnSalvarProdEstoque.Enabled = true;
            btnCancelarEstoque.Enabled = true;

            txtCodigoEstoque.Enabled = false;
            btnEditarEstoque.Enabled = false;
            btnExcluirEstoque.Enabled = false;
            btnNovoEstoque.Enabled = false;

            txtCodigoEstoque.Text = null;
            txtProdutoEstoque.Text = null;
            txtQuantidadeEstoque.Text = null;
            cbTamanhoEstoque.Text = null;
            txtValorCompraEstoque.Text = null;
            txtValorVendaEstoque.Text = null;
        }
        private void btnCancelarEstoque_Click(object sender, EventArgs e)
        {
            txtCodigoEstoque.Text = null;
            txtProdutoEstoque.Text = null;
            txtQuantidadeEstoque.Text = null;
            txtValorCompraEstoque.Text = null;
            txtValorVendaEstoque.Text = null;
            cbTamanhoEstoque.Text = null;

            txtCodigoEstoque.Enabled = false;
            txtProdutoEstoque.Enabled = false;
            txtQuantidadeEstoque.Enabled = false;
            txtValorCompraEstoque.Enabled = false;
            txtValorVendaEstoque.Enabled = false;
            cbTamanhoEstoque.Enabled = false;

            btnSalvarProdEstoque.Enabled = false;
            btnCancelarEstoque.Enabled = false;

            btnEditarEstoque.Enabled = true;
            btnExcluirEstoque.Enabled = true;
            btnNovoEstoque.Enabled = true;
        }
        private void btnSalvarProdEstoque_Click(object sender, EventArgs e)
        {
            int quantidadeEstoque, ativo;
            string produtoEstoque, tamanhoEstoque, statusEstoque;
            decimal valorCompraEstoque, valorVendaEstoque;

            if (is_salve)
            {
                quantidadeEstoque = Convert.ToInt32(txtQuantidadeEstoque.Text);
                valorCompraEstoque = Convert.ToDecimal(txtValorCompraEstoque.Text);
                valorVendaEstoque = Convert.ToDecimal(txtValorVendaEstoque.Text);
                produtoEstoque = txtProdutoEstoque.Text;
                tamanhoEstoque = cbTamanhoEstoque.Text;

                

                ctrll.PegaRegistroEstoque(produtoEstoque, quantidadeEstoque, tamanhoEstoque,
                                                    valorCompraEstoque, valorVendaEstoque);
                txtCodigoEstoque.Text = null;
                cbTamanhoEstoque.Text = "P";
                txtProdutoEstoque.Text = null;
                txtQuantidadeEstoque.Text = null;
                txtValorCompraEstoque.Text = null;
                txtValorVendaEstoque.Text = null;

                ExibeEstoque();
            }
            else
            {
                ctrll.EditarEstoque(Convert.ToInt32(txtCodigoEstoque.Text), txtProdutoEstoque.Text, Convert.ToInt32(txtQuantidadeEstoque.Text),
                                              cbTamanhoEstoque.Text, Convert.ToDecimal(txtValorCompraEstoque.Text),
                                              Convert.ToDecimal(txtValorVendaEstoque.Text));
                ExibeEstoque();
            }            
        }
        private void dataEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigoEstoque, quantidadeEstoque;
            string produtoEstoque, tamanhoEstoque;
            decimal valorCompraEstoque, valorVendaEstoque;

            codigoEstoque = (Int32)dataEstoque.CurrentRow.Cells[0].Value;
            produtoEstoque = dataEstoque.CurrentRow.Cells[1].Value.ToString();
            quantidadeEstoque = (Int32)dataEstoque.CurrentRow.Cells[2].Value;
            tamanhoEstoque = dataEstoque.CurrentRow.Cells[3].Value.ToString();
            valorCompraEstoque = Convert.ToDecimal(dataEstoque.CurrentRow.Cells[4].Value);
            valorVendaEstoque = Convert.ToDecimal(dataEstoque.CurrentRow.Cells[5].Value);

            txtCodigoEstoque.Text = Convert.ToString(codigoEstoque);
            txtProdutoEstoque.Text = produtoEstoque;
            cbTamanhoEstoque.Text = tamanhoEstoque;
            txtQuantidadeEstoque.Text = Convert.ToString(quantidadeEstoque);
            txtValorCompraEstoque.Text = Convert.ToString(valorCompraEstoque);
            txtValorVendaEstoque.Text = Convert.ToString(valorVendaEstoque);
        }
        private void btnEditarEstoque_Click(object sender, EventArgs e)
        {
            is_salve = false;

            txtValorVendaEstoque.Enabled = true;
            txtValorCompraEstoque.Enabled = true;
            txtQuantidadeEstoque.Enabled = true;
            txtProdutoEstoque.Enabled = true;
            cbTamanhoEstoque.Enabled = true;

            btnCancelarEstoque.Enabled = true;
            btnSalvarProdEstoque.Enabled = true;
            btnEditarEstoque.Enabled = false;
            btnNovoEstoque.Enabled = false;
            btnExcluirEstoque.Enabled = false;            
        }

        private void btnExcluirEstoque_Click(object sender, EventArgs e)
        {
            if(txtProdutoEstoque.Text == "")
            {
                MessageBox.Show("Selecione um item do Estoque");
            }else
            {
                DialogResult dr = MessageBox.Show("Deseja Excluir este item?", "Warning", MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Information);
                if(dr == DialogResult.OK)
                {
                    ctrll.ExcluirItemEstoque(Convert.ToInt32(txtCodigoEstoque.Text));
                    ExibeEstoque();
                }
            }
        }
        

        private void btnRelatorioEstoque_Click(object sender, EventArgs e)
        {
            ctrll.ExRelatorio();
           
        }
        private void btnPesquisarEstoque_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table = ctrll.PesquisaEstoque(txtPesquisarEstoque.Text);

            dataEstoque.DataSource = table;  
        }
        #endregion
    }
}
