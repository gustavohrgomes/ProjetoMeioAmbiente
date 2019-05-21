namespace projetoMeioAmbiente
{
    partial class cadastrarRua
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarRua));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.label_Endereco = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label_Cep = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtQntdArvores = new System.Windows.Forms.TextBox();
            this.label_QntdArvores = new System.Windows.Forms.Label();
            this.txtQntdCasas = new System.Windows.Forms.TextBox();
            this.label_QntdCasas = new System.Windows.Forms.Label();
            this.epCadastrarRua = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCadastrarRua)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(480, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(23, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // label_Endereco
            // 
            this.label_Endereco.AutoSize = true;
            this.label_Endereco.Location = new System.Drawing.Point(9, 31);
            this.label_Endereco.Name = "label_Endereco";
            this.label_Endereco.Size = new System.Drawing.Size(54, 13);
            this.label_Endereco.TabIndex = 3;
            this.label_Endereco.Text = "Endereço";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 45);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(340, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // label_Cep
            // 
            this.label_Cep.AutoSize = true;
            this.label_Cep.Location = new System.Drawing.Point(370, 31);
            this.label_Cep.Name = "label_Cep";
            this.label_Cep.Size = new System.Drawing.Size(27, 13);
            this.label_Cep.TabIndex = 6;
            this.label_Cep.Text = "Cep";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(373, 45);
            this.mskCep.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(84, 22);
            this.mskCep.TabIndex = 2;
            // 
            // label_Bairro
            // 
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.Location = new System.Drawing.Point(9, 72);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(38, 13);
            this.label_Bairro.TabIndex = 8;
            this.label_Bairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 86);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(178, 22);
            this.txtBairro.TabIndex = 3;
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(206, 72);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(43, 13);
            this.label_Cidade.TabIndex = 10;
            this.label_Cidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(209, 86);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(143, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // txtQntdArvores
            // 
            this.txtQntdArvores.Location = new System.Drawing.Point(209, 124);
            this.txtQntdArvores.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.txtQntdArvores.Name = "txtQntdArvores";
            this.txtQntdArvores.Size = new System.Drawing.Size(143, 22);
            this.txtQntdArvores.TabIndex = 6;
            this.txtQntdArvores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQntdArvores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntdArvores_KeyPress);
            // 
            // label_QntdArvores
            // 
            this.label_QntdArvores.AutoSize = true;
            this.label_QntdArvores.Location = new System.Drawing.Point(206, 111);
            this.label_QntdArvores.Name = "label_QntdArvores";
            this.label_QntdArvores.Size = new System.Drawing.Size(124, 13);
            this.label_QntdArvores.TabIndex = 15;
            this.label_QntdArvores.Text = "Quantidade de Árvores";
            // 
            // txtQntdCasas
            // 
            this.txtQntdCasas.Location = new System.Drawing.Point(12, 124);
            this.txtQntdCasas.Name = "txtQntdCasas";
            this.txtQntdCasas.Size = new System.Drawing.Size(178, 22);
            this.txtQntdCasas.TabIndex = 5;
            this.txtQntdCasas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQntdCasas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntdCasas_KeyPress);
            // 
            // label_QntdCasas
            // 
            this.label_QntdCasas.AutoSize = true;
            this.label_QntdCasas.Location = new System.Drawing.Point(9, 111);
            this.label_QntdCasas.Name = "label_QntdCasas";
            this.label_QntdCasas.Size = new System.Drawing.Size(114, 13);
            this.label_QntdCasas.TabIndex = 13;
            this.label_QntdCasas.Text = "Quantidade de Casas";
            // 
            // epCadastrarRua
            // 
            this.epCadastrarRua.BlinkRate = 500;
            this.epCadastrarRua.ContainerControl = this;
            this.epCadastrarRua.Icon = ((System.Drawing.Icon)(resources.GetObject("epCadastrarRua.Icon")));
            // 
            // cadastrarRua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(480, 156);
            this.Controls.Add(this.txtQntdArvores);
            this.Controls.Add(this.label_QntdArvores);
            this.Controls.Add(this.txtQntdCasas);
            this.Controls.Add(this.label_QntdCasas);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label_Cidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label_Bairro);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.label_Cep);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label_Endereco);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cadastrarRua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CADASTRAR RUA";
            this.Load += new System.EventHandler(this.cadastrarRua_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCadastrarRua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Label label_Endereco;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label_Cep;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label_Bairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtQntdArvores;
        private System.Windows.Forms.Label label_QntdArvores;
        private System.Windows.Forms.TextBox txtQntdCasas;
        private System.Windows.Forms.Label label_QntdCasas;
        private System.Windows.Forms.ErrorProvider epCadastrarRua;
    }
}