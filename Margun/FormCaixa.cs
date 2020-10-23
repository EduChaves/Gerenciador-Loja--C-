using Margun.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Margun
{
    public partial class FormCaixa : Form
    {
        CaixaController caixaCtrll = new CaixaController();
        public FormCaixa()
        {
            InitializeComponent();
            txtQuantidadeCaixa.Text = "1";

            ExibeCarrinho();
        }
        private void ExibeCarrinho()
        {
            DataTable table = new DataTable();

            table = caixaCtrll.ExibeCarrinho();

            dataCarrinhoCaixa.DataSource = table;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            txtQuantidadeCaixa.Enabled = true;

            DataTable table = new DataTable();

            table = caixaCtrll.BuscaProduto(Convert.ToInt32(txtCodigoCaixa.Text));
            txtValorCaixa.Text = table.Rows[0]["valorVendaEstoque"].ToString();
            txtProdutoCaixa.Text = table.Rows[0]["produtoEstoque"].ToString();
            txtTamanhoCaixa.Text = table.Rows[0]["tamanhoEstoque"].ToString();            
        }

        private void radioCartao_CheckedChanged(object sender, EventArgs e)
        {
            txtParcelasCaixa.Enabled = true;
            txtDescontoCaixa.Enabled = true;
        }

        private void btnCarrinhoCaixa_Click(object sender, EventArgs e)
        {
            caixaCtrll.AddCarrinho(Convert.ToInt32(txtCodigoCaixa.Text), txtProdutoCaixa.Text, Convert.ToInt32(txtQuantidadeCaixa.Text),
                                    txtTamanhoCaixa.Text, Convert.ToDecimal(txtValorCaixa.Text));
            ExibeCarrinho();
        }
    }
}
