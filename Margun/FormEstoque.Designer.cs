namespace Margun
{
    partial class FormEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.btnRelatorioEstoque = new System.Windows.Forms.Button();
            this.dataEstoque = new System.Windows.Forms.DataGridView();
            this.txtPesquisarEstoque = new System.Windows.Forms.TextBox();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.btnCancelarEstoque = new System.Windows.Forms.Button();
            this.btnExcluirEstoque = new System.Windows.Forms.Button();
            this.btnEditarEstoque = new System.Windows.Forms.Button();
            this.btnSalvarProdEstoque = new System.Windows.Forms.Button();
            this.btnNovoEstoque = new System.Windows.Forms.Button();
            this.groupAddProd = new System.Windows.Forms.GroupBox();
            this.labelCodigoEstoque = new System.Windows.Forms.Label();
            this.txtCodigoEstoque = new System.Windows.Forms.TextBox();
            this.txtValorVendaEstoque = new System.Windows.Forms.TextBox();
            this.txtValorCompraEstoque = new System.Windows.Forms.TextBox();
            this.labelQuantidadeEstoque = new System.Windows.Forms.Label();
            this.txtQuantidadeEstoque = new System.Windows.Forms.TextBox();
            this.cbTamanhoEstoque = new System.Windows.Forms.ComboBox();
            this.txtProdutoEstoque = new System.Windows.Forms.TextBox();
            this.labelValorVendaEstoque = new System.Windows.Forms.Label();
            this.labelValorCompraEstoque = new System.Windows.Forms.Label();
            this.labelTamanhoEstoque = new System.Windows.Forms.Label();
            this.labelProdutoEstoque = new System.Windows.Forms.Label();
            this.panelEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstoque)).BeginInit();
            this.groupAddProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEstoque
            // 
            this.panelEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEstoque.Controls.Add(this.btnRelatorioEstoque);
            this.panelEstoque.Controls.Add(this.dataEstoque);
            this.panelEstoque.Controls.Add(this.txtPesquisarEstoque);
            this.panelEstoque.Controls.Add(this.btnPesquisarEstoque);
            this.panelEstoque.Controls.Add(this.btnCancelarEstoque);
            this.panelEstoque.Controls.Add(this.btnExcluirEstoque);
            this.panelEstoque.Controls.Add(this.btnEditarEstoque);
            this.panelEstoque.Controls.Add(this.btnSalvarProdEstoque);
            this.panelEstoque.Controls.Add(this.btnNovoEstoque);
            this.panelEstoque.Controls.Add(this.groupAddProd);
            this.panelEstoque.Location = new System.Drawing.Point(0, 0);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(696, 573);
            this.panelEstoque.TabIndex = 0;
            // 
            // btnRelatorioEstoque
            // 
            this.btnRelatorioEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnRelatorioEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorioEstoque.Location = new System.Drawing.Point(12, 528);
            this.btnRelatorioEstoque.Name = "btnRelatorioEstoque";
            this.btnRelatorioEstoque.Size = new System.Drawing.Size(127, 33);
            this.btnRelatorioEstoque.TabIndex = 17;
            this.btnRelatorioEstoque.Text = "Gerar Relatório";
            this.btnRelatorioEstoque.UseVisualStyleBackColor = false;
            this.btnRelatorioEstoque.Click += new System.EventHandler(this.btnRelatorioEstoque_Click);
            // 
            // dataEstoque
            // 
            this.dataEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataEstoque.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataEstoque.EnableHeadersVisualStyles = false;
            this.dataEstoque.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataEstoque.Location = new System.Drawing.Point(12, 170);
            this.dataEstoque.Name = "dataEstoque";
            this.dataEstoque.Size = new System.Drawing.Size(672, 352);
            this.dataEstoque.TabIndex = 16;
            this.dataEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstoque_CellContentClick);
            // 
            // txtPesquisarEstoque
            // 
            this.txtPesquisarEstoque.Location = new System.Drawing.Point(375, 141);
            this.txtPesquisarEstoque.Name = "txtPesquisarEstoque";
            this.txtPesquisarEstoque.Size = new System.Drawing.Size(212, 20);
            this.txtPesquisarEstoque.TabIndex = 13;
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnPesquisarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(593, 136);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(91, 28);
            this.btnPesquisarEstoque.TabIndex = 15;
            this.btnPesquisarEstoque.Text = "Pesquisar";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = false;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.btnPesquisarEstoque_Click);
            // 
            // btnCancelarEstoque
            // 
            this.btnCancelarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnCancelarEstoque.Enabled = false;
            this.btnCancelarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEstoque.Location = new System.Drawing.Point(278, 135);
            this.btnCancelarEstoque.Name = "btnCancelarEstoque";
            this.btnCancelarEstoque.Size = new System.Drawing.Size(82, 28);
            this.btnCancelarEstoque.TabIndex = 14;
            this.btnCancelarEstoque.Text = "Cancelar";
            this.btnCancelarEstoque.UseVisualStyleBackColor = false;
            this.btnCancelarEstoque.Click += new System.EventHandler(this.btnCancelarEstoque_Click);
            // 
            // btnExcluirEstoque
            // 
            this.btnExcluirEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnExcluirEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirEstoque.Location = new System.Drawing.Point(208, 135);
            this.btnExcluirEstoque.Name = "btnExcluirEstoque";
            this.btnExcluirEstoque.Size = new System.Drawing.Size(64, 28);
            this.btnExcluirEstoque.TabIndex = 13;
            this.btnExcluirEstoque.Text = "Excluir";
            this.btnExcluirEstoque.UseVisualStyleBackColor = false;
            this.btnExcluirEstoque.Click += new System.EventHandler(this.btnExcluirEstoque_Click);
            // 
            // btnEditarEstoque
            // 
            this.btnEditarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnEditarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEstoque.Location = new System.Drawing.Point(140, 136);
            this.btnEditarEstoque.Name = "btnEditarEstoque";
            this.btnEditarEstoque.Size = new System.Drawing.Size(62, 27);
            this.btnEditarEstoque.TabIndex = 12;
            this.btnEditarEstoque.Text = "Editar";
            this.btnEditarEstoque.UseVisualStyleBackColor = false;
            this.btnEditarEstoque.Click += new System.EventHandler(this.btnEditarEstoque_Click);
            // 
            // btnSalvarProdEstoque
            // 
            this.btnSalvarProdEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnSalvarProdEstoque.Enabled = false;
            this.btnSalvarProdEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProdEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProdEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarProdEstoque.Location = new System.Drawing.Point(72, 136);
            this.btnSalvarProdEstoque.Name = "btnSalvarProdEstoque";
            this.btnSalvarProdEstoque.Size = new System.Drawing.Size(62, 27);
            this.btnSalvarProdEstoque.TabIndex = 11;
            this.btnSalvarProdEstoque.Text = "Salvar";
            this.btnSalvarProdEstoque.UseVisualStyleBackColor = false;
            this.btnSalvarProdEstoque.Click += new System.EventHandler(this.btnSalvarProdEstoque_Click);
            // 
            // btnNovoEstoque
            // 
            this.btnNovoEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnNovoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoEstoque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovoEstoque.Location = new System.Drawing.Point(12, 136);
            this.btnNovoEstoque.Name = "btnNovoEstoque";
            this.btnNovoEstoque.Size = new System.Drawing.Size(54, 27);
            this.btnNovoEstoque.TabIndex = 10;
            this.btnNovoEstoque.Text = "Novo";
            this.btnNovoEstoque.UseVisualStyleBackColor = false;
            this.btnNovoEstoque.Click += new System.EventHandler(this.btnNovoEstoque_Click);
            // 
            // groupAddProd
            // 
            this.groupAddProd.Controls.Add(this.labelCodigoEstoque);
            this.groupAddProd.Controls.Add(this.txtCodigoEstoque);
            this.groupAddProd.Controls.Add(this.txtValorVendaEstoque);
            this.groupAddProd.Controls.Add(this.txtValorCompraEstoque);
            this.groupAddProd.Controls.Add(this.labelQuantidadeEstoque);
            this.groupAddProd.Controls.Add(this.txtQuantidadeEstoque);
            this.groupAddProd.Controls.Add(this.cbTamanhoEstoque);
            this.groupAddProd.Controls.Add(this.txtProdutoEstoque);
            this.groupAddProd.Controls.Add(this.labelValorVendaEstoque);
            this.groupAddProd.Controls.Add(this.labelValorCompraEstoque);
            this.groupAddProd.Controls.Add(this.labelTamanhoEstoque);
            this.groupAddProd.Controls.Add(this.labelProdutoEstoque);
            this.groupAddProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddProd.ForeColor = System.Drawing.Color.White;
            this.groupAddProd.Location = new System.Drawing.Point(12, 3);
            this.groupAddProd.Name = "groupAddProd";
            this.groupAddProd.Size = new System.Drawing.Size(672, 127);
            this.groupAddProd.TabIndex = 0;
            this.groupAddProd.TabStop = false;
            this.groupAddProd.Text = "Estoque";
            // 
            // labelCodigoEstoque
            // 
            this.labelCodigoEstoque.AutoSize = true;
            this.labelCodigoEstoque.Location = new System.Drawing.Point(32, 28);
            this.labelCodigoEstoque.Name = "labelCodigoEstoque";
            this.labelCodigoEstoque.Size = new System.Drawing.Size(60, 18);
            this.labelCodigoEstoque.TabIndex = 16;
            this.labelCodigoEstoque.Text = "Codigo";
            // 
            // txtCodigoEstoque
            // 
            this.txtCodigoEstoque.Enabled = false;
            this.txtCodigoEstoque.Location = new System.Drawing.Point(101, 25);
            this.txtCodigoEstoque.Name = "txtCodigoEstoque";
            this.txtCodigoEstoque.Size = new System.Drawing.Size(59, 26);
            this.txtCodigoEstoque.TabIndex = 15;
            // 
            // txtValorVendaEstoque
            // 
            this.txtValorVendaEstoque.Enabled = false;
            this.txtValorVendaEstoque.Location = new System.Drawing.Point(534, 89);
            this.txtValorVendaEstoque.Name = "txtValorVendaEstoque";
            this.txtValorVendaEstoque.Size = new System.Drawing.Size(95, 26);
            this.txtValorVendaEstoque.TabIndex = 14;
            // 
            // txtValorCompraEstoque
            // 
            this.txtValorCompraEstoque.Enabled = false;
            this.txtValorCompraEstoque.Location = new System.Drawing.Point(534, 57);
            this.txtValorCompraEstoque.Name = "txtValorCompraEstoque";
            this.txtValorCompraEstoque.Size = new System.Drawing.Size(95, 26);
            this.txtValorCompraEstoque.TabIndex = 13;
            // 
            // labelQuantidadeEstoque
            // 
            this.labelQuantidadeEstoque.AutoSize = true;
            this.labelQuantidadeEstoque.Location = new System.Drawing.Point(439, 28);
            this.labelQuantidadeEstoque.Name = "labelQuantidadeEstoque";
            this.labelQuantidadeEstoque.Size = new System.Drawing.Size(89, 18);
            this.labelQuantidadeEstoque.TabIndex = 12;
            this.labelQuantidadeEstoque.Text = "Quantidade";
            // 
            // txtQuantidadeEstoque
            // 
            this.txtQuantidadeEstoque.Enabled = false;
            this.txtQuantidadeEstoque.Location = new System.Drawing.Point(534, 25);
            this.txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            this.txtQuantidadeEstoque.Size = new System.Drawing.Size(95, 26);
            this.txtQuantidadeEstoque.TabIndex = 11;
            // 
            // cbTamanhoEstoque
            // 
            this.cbTamanhoEstoque.Enabled = false;
            this.cbTamanhoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTamanhoEstoque.FormattingEnabled = true;
            this.cbTamanhoEstoque.Items.AddRange(new object[] {
            "P",
            "M",
            "G",
            "GG"});
            this.cbTamanhoEstoque.Location = new System.Drawing.Point(101, 89);
            this.cbTamanhoEstoque.Name = "cbTamanhoEstoque";
            this.cbTamanhoEstoque.Size = new System.Drawing.Size(59, 26);
            this.cbTamanhoEstoque.TabIndex = 10;
            this.cbTamanhoEstoque.Text = "P";
            // 
            // txtProdutoEstoque
            // 
            this.txtProdutoEstoque.Enabled = false;
            this.txtProdutoEstoque.Location = new System.Drawing.Point(101, 57);
            this.txtProdutoEstoque.Name = "txtProdutoEstoque";
            this.txtProdutoEstoque.Size = new System.Drawing.Size(282, 26);
            this.txtProdutoEstoque.TabIndex = 6;
            // 
            // labelValorVendaEstoque
            // 
            this.labelValorVendaEstoque.AutoSize = true;
            this.labelValorVendaEstoque.Location = new System.Drawing.Point(413, 92);
            this.labelValorVendaEstoque.Name = "labelValorVendaEstoque";
            this.labelValorVendaEstoque.Size = new System.Drawing.Size(115, 18);
            this.labelValorVendaEstoque.TabIndex = 4;
            this.labelValorVendaEstoque.Text = "Valor de Venda";
            // 
            // labelValorCompraEstoque
            // 
            this.labelValorCompraEstoque.AutoSize = true;
            this.labelValorCompraEstoque.Location = new System.Drawing.Point(401, 60);
            this.labelValorCompraEstoque.Name = "labelValorCompraEstoque";
            this.labelValorCompraEstoque.Size = new System.Drawing.Size(127, 18);
            this.labelValorCompraEstoque.TabIndex = 3;
            this.labelValorCompraEstoque.Text = "Valor de Compra";
            // 
            // labelTamanhoEstoque
            // 
            this.labelTamanhoEstoque.AutoSize = true;
            this.labelTamanhoEstoque.Location = new System.Drawing.Point(24, 92);
            this.labelTamanhoEstoque.Name = "labelTamanhoEstoque";
            this.labelTamanhoEstoque.Size = new System.Drawing.Size(71, 18);
            this.labelTamanhoEstoque.TabIndex = 2;
            this.labelTamanhoEstoque.Text = "Tamanho";
            // 
            // labelProdutoEstoque
            // 
            this.labelProdutoEstoque.AutoSize = true;
            this.labelProdutoEstoque.Location = new System.Drawing.Point(32, 60);
            this.labelProdutoEstoque.Name = "labelProdutoEstoque";
            this.labelProdutoEstoque.Size = new System.Drawing.Size(63, 18);
            this.labelProdutoEstoque.TabIndex = 1;
            this.labelProdutoEstoque.Text = "Produto";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(696, 573);
            this.Controls.Add(this.panelEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstoque)).EndInit();
            this.groupAddProd.ResumeLayout(false);
            this.groupAddProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstoque;
        private System.Windows.Forms.GroupBox groupAddProd;
        private System.Windows.Forms.Label labelValorVendaEstoque;
        private System.Windows.Forms.Label labelValorCompraEstoque;
        private System.Windows.Forms.Label labelTamanhoEstoque;
        private System.Windows.Forms.Label labelProdutoEstoque;
        private System.Windows.Forms.TextBox txtProdutoEstoque;
        private System.Windows.Forms.Button btnNovoEstoque;
        private System.Windows.Forms.ComboBox cbTamanhoEstoque;
        private System.Windows.Forms.Button btnExcluirEstoque;
        private System.Windows.Forms.Button btnEditarEstoque;
        private System.Windows.Forms.Button btnSalvarProdEstoque;
        private System.Windows.Forms.Label labelQuantidadeEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeEstoque;
        private System.Windows.Forms.Button btnRelatorioEstoque;
        private System.Windows.Forms.DataGridView dataEstoque;
        private System.Windows.Forms.TextBox txtPesquisarEstoque;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.Button btnCancelarEstoque;
        private System.Windows.Forms.TextBox txtValorVendaEstoque;
        private System.Windows.Forms.TextBox txtValorCompraEstoque;
        private System.Windows.Forms.Label labelCodigoEstoque;
        private System.Windows.Forms.TextBox txtCodigoEstoque;
    }
}