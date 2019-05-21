namespace projetoMeioAmbiente
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarRua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarArvore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaRua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaArvore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpcoes,
            this.tsmConsultar,
            this.tsmSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmOpcoes
            // 
            this.tsmOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCadastrarRua,
            this.tsmiCadastrarArvore});
            this.tsmOpcoes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmOpcoes.Name = "tsmOpcoes";
            this.tsmOpcoes.Size = new System.Drawing.Size(64, 20);
            this.tsmOpcoes.Text = "OPÇÕES";
            // 
            // tsmiCadastrarRua
            // 
            this.tsmiCadastrarRua.Name = "tsmiCadastrarRua";
            this.tsmiCadastrarRua.Size = new System.Drawing.Size(195, 28);
            this.tsmiCadastrarRua.Text = "CADASTRAR RUA";
            this.tsmiCadastrarRua.Click += new System.EventHandler(this.tsmiCadastrarRua_Click);
            // 
            // tsmiCadastrarArvore
            // 
            this.tsmiCadastrarArvore.Name = "tsmiCadastrarArvore";
            this.tsmiCadastrarArvore.Size = new System.Drawing.Size(195, 28);
            this.tsmiCadastrarArvore.Text = "CADASTRAR ÁRVORE";
            this.tsmiCadastrarArvore.Click += new System.EventHandler(this.tsmiCadastrarArvore_Click);
            // 
            // tsmConsultar
            // 
            this.tsmConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsultaRua,
            this.tsmiConsultaArvore});
            this.tsmConsultar.Name = "tsmConsultar";
            this.tsmConsultar.Size = new System.Drawing.Size(91, 21);
            this.tsmConsultar.Text = "CONSULTAR";
            // 
            // tsmiConsultaRua
            // 
            this.tsmiConsultaRua.Name = "tsmiConsultaRua";
            this.tsmiConsultaRua.Size = new System.Drawing.Size(125, 28);
            this.tsmiConsultaRua.Text = "RUA";
            this.tsmiConsultaRua.Click += new System.EventHandler(this.tsmiConsultaRua_Click);
            // 
            // tsmiConsultaArvore
            // 
            this.tsmiConsultaArvore.Name = "tsmiConsultaArvore";
            this.tsmiConsultaArvore.Size = new System.Drawing.Size(125, 28);
            this.tsmiConsultaArvore.Text = "ÁRVORE";
            this.tsmiConsultaArvore.Click += new System.EventHandler(this.tsmiConsultaArvore_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(48, 28);
            this.tsmSair.Text = "SAIR";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarArvore;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarRua;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaArvore;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaRua;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
    }
}

