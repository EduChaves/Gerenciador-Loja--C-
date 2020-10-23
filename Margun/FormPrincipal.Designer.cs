namespace Margun
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnTroca = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBarraSup = new System.Windows.Forms.Panel();
            this.btnMinMax = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCloseWindow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMinimize = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMaxMin = new System.Windows.Forms.FlowLayoutPanel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelBarraSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnFinanceiro);
            this.panelMenu.Controls.Add(this.btnTroca);
            this.panelMenu.Controls.Add(this.btnCaixa);
            this.panelMenu.Controls.Add(this.btnEstoque);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(204, 607);
            this.panelMenu.TabIndex = 1;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfig.Location = new System.Drawing.Point(3, 554);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(194, 41);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinanceiro.Location = new System.Drawing.Point(3, 289);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(194, 41);
            this.btnFinanceiro.TabIndex = 5;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // btnTroca
            // 
            this.btnTroca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTroca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroca.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTroca.Location = new System.Drawing.Point(3, 242);
            this.btnTroca.Name = "btnTroca";
            this.btnTroca.Size = new System.Drawing.Size(194, 41);
            this.btnTroca.TabIndex = 4;
            this.btnTroca.Text = "Troca";
            this.btnTroca.UseVisualStyleBackColor = true;
            this.btnTroca.Click += new System.EventHandler(this.btnTroca_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaixa.Location = new System.Drawing.Point(3, 195);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(194, 41);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEstoque.Location = new System.Drawing.Point(3, 148);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(194, 41);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Margun.Properties.Resources.WhatsApp_Image_2020_07_23_at_12_removebg_preview__1_;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(12, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(186, 99);
            this.panelLogo.TabIndex = 0;
            // 
            // panelBarraSup
            // 
            this.panelBarraSup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panelBarraSup.Controls.Add(this.btnMinMax);
            this.panelBarraSup.Controls.Add(this.btnCloseWindow);
            this.panelBarraSup.Controls.Add(this.btnMinimize);
            this.panelBarraSup.Controls.Add(this.btnMaxMin);
            this.panelBarraSup.Location = new System.Drawing.Point(204, 0);
            this.panelBarraSup.Name = "panelBarraSup";
            this.panelBarraSup.Size = new System.Drawing.Size(696, 34);
            this.panelBarraSup.TabIndex = 4;
            this.panelBarraSup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraSup_MouseMove);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinMax.BackgroundImage = global::Margun.Properties.Resources.icons8_comprimir_50;
            this.btnMinMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinMax.Location = new System.Drawing.Point(613, 3);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(27, 23);
            this.btnMinMax.TabIndex = 5;
            this.btnMinMax.Visible = false;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackgroundImage = global::Margun.Properties.Resources.icons8_excluir_50;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Location = new System.Drawing.Point(658, 3);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(26, 23);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::Margun.Properties.Resources.icons8_minimizar_janela_50__1_;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(570, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 23);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxMin.BackgroundImage = global::Margun.Properties.Resources.icons8_ajustar_à_largura_50;
            this.btnMaxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaxMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxMin.Location = new System.Drawing.Point(613, 3);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(27, 23);
            this.btnMaxMin.TabIndex = 2;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // panelForms
            // 
            this.panelForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForms.Location = new System.Drawing.Point(204, 34);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(696, 573);
            this.panelForms.TabIndex = 5;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(900, 607);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelBarraSup);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelBarraSup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnTroca;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.FlowLayoutPanel btnMaxMin;
        private System.Windows.Forms.FlowLayoutPanel btnMinimize;
        private System.Windows.Forms.FlowLayoutPanel btnCloseWindow;
        private System.Windows.Forms.Panel panelBarraSup;
        private System.Windows.Forms.FlowLayoutPanel btnMinMax;
        private System.Windows.Forms.Panel panelForms;
    }
}

