namespace Margun
{
    partial class FormCaixa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataVendasCaixa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTamanhoCaixa = new System.Windows.Forms.Label();
            this.txtTamanhoCaixa = new System.Windows.Forms.TextBox();
            this.btnBuscaCaixa = new System.Windows.Forms.Button();
            this.btnRemoverCaixa = new System.Windows.Forms.Button();
            this.btnFinalizaCompraCaixa = new System.Windows.Forms.Button();
            this.txtValorTotalCaixa = new System.Windows.Forms.TextBox();
            this.dataCarrinhoCaixa = new System.Windows.Forms.DataGridView();
            this.txtParcelasCaixa = new System.Windows.Forms.TextBox();
            this.txtDescontoCaixa = new System.Windows.Forms.TextBox();
            this.labelValorTotalCaixa = new System.Windows.Forms.Label();
            this.labelParcelasCaixa = new System.Windows.Forms.Label();
            this.labelDescontoCaixa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioDinheiro = new System.Windows.Forms.RadioButton();
            this.radioCartao = new System.Windows.Forms.RadioButton();
            this.checkParceladoCaixa = new System.Windows.Forms.CheckBox();
            this.checkVistaCaixa = new System.Windows.Forms.CheckBox();
            this.btnCarrinhoCaixa = new System.Windows.Forms.Button();
            this.txtValorCaixa = new System.Windows.Forms.TextBox();
            this.txtQuantidadeCaixa = new System.Windows.Forms.TextBox();
            this.txtProdutoCaixa = new System.Windows.Forms.TextBox();
            this.txtCodigoCaixa = new System.Windows.Forms.TextBox();
            this.labelQuantidadeCaixa = new System.Windows.Forms.Label();
            this.labelValorCaixa = new System.Windows.Forms.Label();
            this.labelCodigoCaixa = new System.Windows.Forms.Label();
            this.labelProdutoCaixa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVendasCaixa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarrinhoCaixa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.dataVendasCaixa);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 556);
            this.panel1.TabIndex = 23;
            this.panel1.Tag = "";
            // 
            // dataVendasCaixa
            // 
            this.dataVendasCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataVendasCaixa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataVendasCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVendasCaixa.Location = new System.Drawing.Point(3, 295);
            this.dataVendasCaixa.Name = "dataVendasCaixa";
            this.dataVendasCaixa.Size = new System.Drawing.Size(687, 245);
            this.dataVendasCaixa.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelTamanhoCaixa);
            this.groupBox1.Controls.Add(this.txtTamanhoCaixa);
            this.groupBox1.Controls.Add(this.btnBuscaCaixa);
            this.groupBox1.Controls.Add(this.btnRemoverCaixa);
            this.groupBox1.Controls.Add(this.btnFinalizaCompraCaixa);
            this.groupBox1.Controls.Add(this.txtValorTotalCaixa);
            this.groupBox1.Controls.Add(this.dataCarrinhoCaixa);
            this.groupBox1.Controls.Add(this.txtParcelasCaixa);
            this.groupBox1.Controls.Add(this.txtDescontoCaixa);
            this.groupBox1.Controls.Add(this.labelValorTotalCaixa);
            this.groupBox1.Controls.Add(this.labelParcelasCaixa);
            this.groupBox1.Controls.Add(this.labelDescontoCaixa);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCarrinhoCaixa);
            this.groupBox1.Controls.Add(this.txtValorCaixa);
            this.groupBox1.Controls.Add(this.txtQuantidadeCaixa);
            this.groupBox1.Controls.Add(this.txtProdutoCaixa);
            this.groupBox1.Controls.Add(this.txtCodigoCaixa);
            this.groupBox1.Controls.Add(this.labelQuantidadeCaixa);
            this.groupBox1.Controls.Add(this.labelValorCaixa);
            this.groupBox1.Controls.Add(this.labelCodigoCaixa);
            this.groupBox1.Controls.Add(this.labelProdutoCaixa);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa";
            // 
            // labelTamanhoCaixa
            // 
            this.labelTamanhoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTamanhoCaixa.AutoSize = true;
            this.labelTamanhoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoCaixa.ForeColor = System.Drawing.Color.White;
            this.labelTamanhoCaixa.Location = new System.Drawing.Point(375, 52);
            this.labelTamanhoCaixa.Name = "labelTamanhoCaixa";
            this.labelTamanhoCaixa.Size = new System.Drawing.Size(71, 18);
            this.labelTamanhoCaixa.TabIndex = 24;
            this.labelTamanhoCaixa.Text = "Tamanho";
            // 
            // txtTamanhoCaixa
            // 
            this.txtTamanhoCaixa.Enabled = false;
            this.txtTamanhoCaixa.Location = new System.Drawing.Point(452, 48);
            this.txtTamanhoCaixa.Name = "txtTamanhoCaixa";
            this.txtTamanhoCaixa.Size = new System.Drawing.Size(76, 26);
            this.txtTamanhoCaixa.TabIndex = 23;
            // 
            // btnBuscaCaixa
            // 
            this.btnBuscaCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnBuscaCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaCaixa.ForeColor = System.Drawing.Color.White;
            this.btnBuscaCaixa.Location = new System.Drawing.Point(480, 112);
            this.btnBuscaCaixa.Name = "btnBuscaCaixa";
            this.btnBuscaCaixa.Size = new System.Drawing.Size(68, 36);
            this.btnBuscaCaixa.TabIndex = 22;
            this.btnBuscaCaixa.Text = "Buscar";
            this.btnBuscaCaixa.UseVisualStyleBackColor = false;
            // 
            // btnRemoverCaixa
            // 
            this.btnRemoverCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnRemoverCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverCaixa.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCaixa.Location = new System.Drawing.Point(464, 195);
            this.btnRemoverCaixa.Name = "btnRemoverCaixa";
            this.btnRemoverCaixa.Size = new System.Drawing.Size(81, 36);
            this.btnRemoverCaixa.TabIndex = 21;
            this.btnRemoverCaixa.Text = "Remover";
            this.btnRemoverCaixa.UseVisualStyleBackColor = false;
            // 
            // btnFinalizaCompraCaixa
            // 
            this.btnFinalizaCompraCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnFinalizaCompraCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizaCompraCaixa.ForeColor = System.Drawing.Color.White;
            this.btnFinalizaCompraCaixa.Location = new System.Drawing.Point(405, 237);
            this.btnFinalizaCompraCaixa.Name = "btnFinalizaCompraCaixa";
            this.btnFinalizaCompraCaixa.Size = new System.Drawing.Size(140, 45);
            this.btnFinalizaCompraCaixa.TabIndex = 20;
            this.btnFinalizaCompraCaixa.Text = "Finalizar Compra";
            this.btnFinalizaCompraCaixa.UseVisualStyleBackColor = false;
            // 
            // txtValorTotalCaixa
            // 
            this.txtValorTotalCaixa.Enabled = false;
            this.txtValorTotalCaixa.Location = new System.Drawing.Point(452, 80);
            this.txtValorTotalCaixa.Name = "txtValorTotalCaixa";
            this.txtValorTotalCaixa.Size = new System.Drawing.Size(93, 26);
            this.txtValorTotalCaixa.TabIndex = 19;
            // 
            // dataCarrinhoCaixa
            // 
            this.dataCarrinhoCaixa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataCarrinhoCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarrinhoCaixa.Location = new System.Drawing.Point(6, 112);
            this.dataCarrinhoCaixa.Name = "dataCarrinhoCaixa";
            this.dataCarrinhoCaixa.Size = new System.Drawing.Size(393, 170);
            this.dataCarrinhoCaixa.TabIndex = 18;
            // 
            // txtParcelasCaixa
            // 
            this.txtParcelasCaixa.Enabled = false;
            this.txtParcelasCaixa.Location = new System.Drawing.Point(101, 80);
            this.txtParcelasCaixa.Name = "txtParcelasCaixa";
            this.txtParcelasCaixa.Size = new System.Drawing.Size(61, 26);
            this.txtParcelasCaixa.TabIndex = 17;
            // 
            // txtDescontoCaixa
            // 
            this.txtDescontoCaixa.Enabled = false;
            this.txtDescontoCaixa.Location = new System.Drawing.Point(252, 80);
            this.txtDescontoCaixa.Name = "txtDescontoCaixa";
            this.txtDescontoCaixa.Size = new System.Drawing.Size(76, 26);
            this.txtDescontoCaixa.TabIndex = 16;
            // 
            // labelValorTotalCaixa
            // 
            this.labelValorTotalCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValorTotalCaixa.AutoSize = true;
            this.labelValorTotalCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalCaixa.ForeColor = System.Drawing.Color.White;
            this.labelValorTotalCaixa.Location = new System.Drawing.Point(366, 83);
            this.labelValorTotalCaixa.Name = "labelValorTotalCaixa";
            this.labelValorTotalCaixa.Size = new System.Drawing.Size(80, 18);
            this.labelValorTotalCaixa.TabIndex = 15;
            this.labelValorTotalCaixa.Text = "Valor Total";
            // 
            // labelParcelasCaixa
            // 
            this.labelParcelasCaixa.AutoSize = true;
            this.labelParcelasCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParcelasCaixa.ForeColor = System.Drawing.Color.White;
            this.labelParcelasCaixa.Location = new System.Drawing.Point(25, 88);
            this.labelParcelasCaixa.Name = "labelParcelasCaixa";
            this.labelParcelasCaixa.Size = new System.Drawing.Size(70, 18);
            this.labelParcelasCaixa.TabIndex = 14;
            this.labelParcelasCaixa.Text = "Parcelas";
            // 
            // labelDescontoCaixa
            // 
            this.labelDescontoCaixa.AutoSize = true;
            this.labelDescontoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescontoCaixa.ForeColor = System.Drawing.Color.White;
            this.labelDescontoCaixa.Location = new System.Drawing.Point(171, 88);
            this.labelDescontoCaixa.Name = "labelDescontoCaixa";
            this.labelDescontoCaixa.Size = new System.Drawing.Size(75, 18);
            this.labelDescontoCaixa.TabIndex = 13;
            this.labelDescontoCaixa.Text = "Desconto";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.radioDinheiro);
            this.groupBox2.Controls.Add(this.radioCartao);
            this.groupBox2.Controls.Add(this.checkParceladoCaixa);
            this.groupBox2.Controls.Add(this.checkVistaCaixa);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(566, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 270);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de Pagamento";
            // 
            // radioDinheiro
            // 
            this.radioDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioDinheiro.AutoSize = true;
            this.radioDinheiro.Location = new System.Drawing.Point(7, 64);
            this.radioDinheiro.Name = "radioDinheiro";
            this.radioDinheiro.Size = new System.Drawing.Size(73, 20);
            this.radioDinheiro.TabIndex = 10;
            this.radioDinheiro.TabStop = true;
            this.radioDinheiro.Text = "Dinheiro";
            this.radioDinheiro.UseVisualStyleBackColor = true;
            // 
            // radioCartao
            // 
            this.radioCartao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioCartao.AutoSize = true;
            this.radioCartao.Location = new System.Drawing.Point(7, 38);
            this.radioCartao.Name = "radioCartao";
            this.radioCartao.Size = new System.Drawing.Size(64, 20);
            this.radioCartao.TabIndex = 9;
            this.radioCartao.TabStop = true;
            this.radioCartao.Text = "Cartão";
            this.radioCartao.UseVisualStyleBackColor = true;
            // 
            // checkParceladoCaixa
            // 
            this.checkParceladoCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkParceladoCaixa.AutoSize = true;
            this.checkParceladoCaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkParceladoCaixa.ForeColor = System.Drawing.Color.White;
            this.checkParceladoCaixa.Location = new System.Drawing.Point(6, 234);
            this.checkParceladoCaixa.Name = "checkParceladoCaixa";
            this.checkParceladoCaixa.Size = new System.Drawing.Size(85, 20);
            this.checkParceladoCaixa.TabIndex = 8;
            this.checkParceladoCaixa.Text = "Parcelado";
            this.checkParceladoCaixa.UseVisualStyleBackColor = true;
            // 
            // checkVistaCaixa
            // 
            this.checkVistaCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVistaCaixa.AutoSize = true;
            this.checkVistaCaixa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVistaCaixa.ForeColor = System.Drawing.Color.White;
            this.checkVistaCaixa.Location = new System.Drawing.Point(6, 215);
            this.checkVistaCaixa.Name = "checkVistaCaixa";
            this.checkVistaCaixa.Size = new System.Drawing.Size(70, 20);
            this.checkVistaCaixa.TabIndex = 7;
            this.checkVistaCaixa.Text = "À Vista";
            this.checkVistaCaixa.UseVisualStyleBackColor = true;
            // 
            // btnCarrinhoCaixa
            // 
            this.btnCarrinhoCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btnCarrinhoCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinhoCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCarrinhoCaixa.Location = new System.Drawing.Point(470, 153);
            this.btnCarrinhoCaixa.Name = "btnCarrinhoCaixa";
            this.btnCarrinhoCaixa.Size = new System.Drawing.Size(78, 36);
            this.btnCarrinhoCaixa.TabIndex = 11;
            this.btnCarrinhoCaixa.Text = "Carrinho";
            this.btnCarrinhoCaixa.UseVisualStyleBackColor = false;
            // 
            // txtValorCaixa
            // 
            this.txtValorCaixa.Enabled = false;
            this.txtValorCaixa.Location = new System.Drawing.Point(252, 49);
            this.txtValorCaixa.Name = "txtValorCaixa";
            this.txtValorCaixa.Size = new System.Drawing.Size(76, 26);
            this.txtValorCaixa.TabIndex = 10;
            // 
            // txtQuantidadeCaixa
            // 
            this.txtQuantidadeCaixa.Enabled = false;
            this.txtQuantidadeCaixa.Location = new System.Drawing.Point(101, 49);
            this.txtQuantidadeCaixa.Name = "txtQuantidadeCaixa";
            this.txtQuantidadeCaixa.Size = new System.Drawing.Size(61, 26);
            this.txtQuantidadeCaixa.TabIndex = 9;
            // 
            // txtProdutoCaixa
            // 
            this.txtProdutoCaixa.Enabled = false;
            this.txtProdutoCaixa.Location = new System.Drawing.Point(252, 17);
            this.txtProdutoCaixa.Name = "txtProdutoCaixa";
            this.txtProdutoCaixa.Size = new System.Drawing.Size(293, 26);
            this.txtProdutoCaixa.TabIndex = 8;
            // 
            // txtCodigoCaixa
            // 
            this.txtCodigoCaixa.Location = new System.Drawing.Point(101, 17);
            this.txtCodigoCaixa.Name = "txtCodigoCaixa";
            this.txtCodigoCaixa.Size = new System.Drawing.Size(61, 26);
            this.txtCodigoCaixa.TabIndex = 7;
            // 
            // labelQuantidadeCaixa
            // 
            this.labelQuantidadeCaixa.AutoSize = true;
            this.labelQuantidadeCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeCaixa.ForeColor = System.Drawing.Color.White;
            this.labelQuantidadeCaixa.Location = new System.Drawing.Point(6, 52);
            this.labelQuantidadeCaixa.Name = "labelQuantidadeCaixa";
            this.labelQuantidadeCaixa.Size = new System.Drawing.Size(89, 18);
            this.labelQuantidadeCaixa.TabIndex = 3;
            this.labelQuantidadeCaixa.Text = "Quantidade";
            // 
            // labelValorCaixa
            // 
            this.labelValorCaixa.AutoSize = true;
            this.labelValorCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorCaixa.ForeColor = System.Drawing.Color.White;
            this.labelValorCaixa.Location = new System.Drawing.Point(202, 56);
            this.labelValorCaixa.Name = "labelValorCaixa";
            this.labelValorCaixa.Size = new System.Drawing.Size(44, 18);
            this.labelValorCaixa.TabIndex = 2;
            this.labelValorCaixa.Text = "Valor";
            // 
            // labelCodigoCaixa
            // 
            this.labelCodigoCaixa.AutoSize = true;
            this.labelCodigoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoCaixa.ForeColor = System.Drawing.Color.White;
            this.labelCodigoCaixa.Location = new System.Drawing.Point(35, 20);
            this.labelCodigoCaixa.Name = "labelCodigoCaixa";
            this.labelCodigoCaixa.Size = new System.Drawing.Size(60, 18);
            this.labelCodigoCaixa.TabIndex = 1;
            this.labelCodigoCaixa.Text = "Codigo";
            // 
            // labelProdutoCaixa
            // 
            this.labelProdutoCaixa.AutoSize = true;
            this.labelProdutoCaixa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoCaixa.ForeColor = System.Drawing.Color.White;
            this.labelProdutoCaixa.Location = new System.Drawing.Point(183, 20);
            this.labelProdutoCaixa.Name = "labelProdutoCaixa";
            this.labelProdutoCaixa.Size = new System.Drawing.Size(63, 18);
            this.labelProdutoCaixa.TabIndex = 0;
            this.labelProdutoCaixa.Text = "Produto";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(756, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVendasCaixa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarrinhoCaixa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataVendasCaixa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTamanhoCaixa;
        private System.Windows.Forms.TextBox txtTamanhoCaixa;
        private System.Windows.Forms.Button btnBuscaCaixa;
        private System.Windows.Forms.Button btnRemoverCaixa;
        private System.Windows.Forms.Button btnFinalizaCompraCaixa;
        private System.Windows.Forms.TextBox txtValorTotalCaixa;
        private System.Windows.Forms.DataGridView dataCarrinhoCaixa;
        private System.Windows.Forms.TextBox txtParcelasCaixa;
        private System.Windows.Forms.TextBox txtDescontoCaixa;
        private System.Windows.Forms.Label labelValorTotalCaixa;
        private System.Windows.Forms.Label labelParcelasCaixa;
        private System.Windows.Forms.Label labelDescontoCaixa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioDinheiro;
        private System.Windows.Forms.RadioButton radioCartao;
        private System.Windows.Forms.CheckBox checkParceladoCaixa;
        private System.Windows.Forms.CheckBox checkVistaCaixa;
        private System.Windows.Forms.Button btnCarrinhoCaixa;
        private System.Windows.Forms.TextBox txtValorCaixa;
        private System.Windows.Forms.TextBox txtQuantidadeCaixa;
        private System.Windows.Forms.TextBox txtProdutoCaixa;
        private System.Windows.Forms.TextBox txtCodigoCaixa;
        private System.Windows.Forms.Label labelQuantidadeCaixa;
        private System.Windows.Forms.Label labelValorCaixa;
        private System.Windows.Forms.Label labelCodigoCaixa;
        private System.Windows.Forms.Label labelProdutoCaixa;
    }
}