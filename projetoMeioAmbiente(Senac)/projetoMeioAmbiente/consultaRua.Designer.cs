namespace projetoMeioAmbiente
{
    partial class consultaRua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaRua));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarEdicao = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.txtQntdArvores = new System.Windows.Forms.TextBox();
            this.label_QntdArvores = new System.Windows.Forms.Label();
            this.txtQntdCasas = new System.Windows.Forms.TextBox();
            this.label_QntdCasas = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label_Cidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label_Cep = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label_Endereco = new System.Windows.Forms.Label();
            this.txtIdRua = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.grpConsultaRua = new System.Windows.Forms.GroupBox();
            this.bancoProjetoDataSet = new projetoMeioAmbiente.bancoProjetoDataSet();
            this.epConsultarRua = new System.Windows.Forms.ErrorProvider(this.components);
            this.bancoProjetoMADataSet = new projetoMeioAmbiente.bancoProjetoMADataSet();
            this.txtPesquisarRuaConsulta = new System.Windows.Forms.TextBox();
            this.dgvConsultaRua = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbPesquisarRua = new System.Windows.Forms.GroupBox();
            this.ruasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruasTableAdapter = new projetoMeioAmbiente.bancoProjetoDataSetTableAdapters.ruasTableAdapter();
            this.idruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntdCasasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntdArvoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.grpConsultaRua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConsultarRua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaRua)).BeginInit();
            this.gpbPesquisarRua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarEdicao,
            this.tsbCancelar,
            this.tsbExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalvarEdicao
            // 
            this.tsbSalvarEdicao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvarEdicao.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvarEdicao.Image")));
            this.tsbSalvarEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarEdicao.Name = "tsbSalvarEdicao";
            this.tsbSalvarEdicao.Size = new System.Drawing.Size(23, 22);
            this.tsbSalvarEdicao.Text = "Salvar Alterações";
            this.tsbSalvarEdicao.Click += new System.EventHandler(this.tsbSalvarEdicao_Click);
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
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Deletar";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // txtQntdArvores
            // 
            this.txtQntdArvores.Location = new System.Drawing.Point(217, 125);
            this.txtQntdArvores.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtQntdArvores.Name = "txtQntdArvores";
            this.txtQntdArvores.Size = new System.Drawing.Size(157, 22);
            this.txtQntdArvores.TabIndex = 6;
            this.txtQntdArvores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntdArvores_KeyPress);
            // 
            // label_QntdArvores
            // 
            this.label_QntdArvores.AutoSize = true;
            this.label_QntdArvores.Location = new System.Drawing.Point(214, 111);
            this.label_QntdArvores.Name = "label_QntdArvores";
            this.label_QntdArvores.Size = new System.Drawing.Size(124, 13);
            this.label_QntdArvores.TabIndex = 29;
            this.label_QntdArvores.Text = "Quantidade de Árvores";
            // 
            // txtQntdCasas
            // 
            this.txtQntdCasas.Location = new System.Drawing.Point(12, 125);
            this.txtQntdCasas.Name = "txtQntdCasas";
            this.txtQntdCasas.Size = new System.Drawing.Size(184, 22);
            this.txtQntdCasas.TabIndex = 5;
            this.txtQntdCasas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQntdCasas_KeyPress);
            // 
            // label_QntdCasas
            // 
            this.label_QntdCasas.AutoSize = true;
            this.label_QntdCasas.Location = new System.Drawing.Point(9, 111);
            this.label_QntdCasas.Name = "label_QntdCasas";
            this.label_QntdCasas.Size = new System.Drawing.Size(114, 13);
            this.label_QntdCasas.TabIndex = 27;
            this.label_QntdCasas.Text = "Quantidade de Casas";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(217, 86);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(157, 22);
            this.txtCidade.TabIndex = 4;
            // 
            // label_Cidade
            // 
            this.label_Cidade.AutoSize = true;
            this.label_Cidade.Location = new System.Drawing.Point(214, 73);
            this.label_Cidade.Name = "label_Cidade";
            this.label_Cidade.Size = new System.Drawing.Size(43, 13);
            this.label_Cidade.TabIndex = 25;
            this.label_Cidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 86);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(18, 3, 18, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(184, 22);
            this.txtBairro.TabIndex = 3;
            // 
            // label_Bairro
            // 
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.Location = new System.Drawing.Point(9, 71);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(38, 13);
            this.label_Bairro.TabIndex = 23;
            this.label_Bairro.Text = "Bairro";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(395, 46);
            this.mskCep.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(80, 22);
            this.mskCep.TabIndex = 2;
            // 
            // label_Cep
            // 
            this.label_Cep.AutoSize = true;
            this.label_Cep.Location = new System.Drawing.Point(392, 33);
            this.label_Cep.Name = "label_Cep";
            this.label_Cep.Size = new System.Drawing.Size(27, 13);
            this.label_Cep.TabIndex = 21;
            this.label_Cep.Text = "Cep";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(86, 46);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(288, 22);
            this.txtEndereco.TabIndex = 1;
            // 
            // label_Endereco
            // 
            this.label_Endereco.AutoSize = true;
            this.label_Endereco.Location = new System.Drawing.Point(83, 33);
            this.label_Endereco.Name = "label_Endereco";
            this.label_Endereco.Size = new System.Drawing.Size(54, 13);
            this.label_Endereco.TabIndex = 19;
            this.label_Endereco.Text = "Endereço";
            // 
            // txtIdRua
            // 
            this.txtIdRua.Location = new System.Drawing.Point(12, 46);
            this.txtIdRua.Name = "txtIdRua";
            this.txtIdRua.ReadOnly = true;
            this.txtIdRua.Size = new System.Drawing.Size(53, 22);
            this.txtIdRua.TabIndex = 0;
            // 
            // label_Id
            // 
            this.label_Id.Location = new System.Drawing.Point(9, 33);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(39, 13);
            this.label_Id.TabIndex = 17;
            this.label_Id.Text = "Id Rua";
            // 
            // grpConsultaRua
            // 
            this.grpConsultaRua.Controls.Add(this.txtEndereco);
            this.grpConsultaRua.Controls.Add(this.txtQntdArvores);
            this.grpConsultaRua.Controls.Add(this.label_Id);
            this.grpConsultaRua.Controls.Add(this.label_QntdArvores);
            this.grpConsultaRua.Controls.Add(this.txtIdRua);
            this.grpConsultaRua.Controls.Add(this.txtQntdCasas);
            this.grpConsultaRua.Controls.Add(this.label_Endereco);
            this.grpConsultaRua.Controls.Add(this.label_QntdCasas);
            this.grpConsultaRua.Controls.Add(this.label_Cep);
            this.grpConsultaRua.Controls.Add(this.txtCidade);
            this.grpConsultaRua.Controls.Add(this.mskCep);
            this.grpConsultaRua.Controls.Add(this.label_Cidade);
            this.grpConsultaRua.Controls.Add(this.label_Bairro);
            this.grpConsultaRua.Controls.Add(this.txtBairro);
            this.grpConsultaRua.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultaRua.Location = new System.Drawing.Point(12, 31);
            this.grpConsultaRua.Name = "grpConsultaRua";
            this.grpConsultaRua.Size = new System.Drawing.Size(504, 175);
            this.grpConsultaRua.TabIndex = 31;
            this.grpConsultaRua.TabStop = false;
            this.grpConsultaRua.Text = "Consultar Rua";
            // 
            // bancoProjetoDataSet
            // 
            this.bancoProjetoDataSet.DataSetName = "bancoProjetoDataSet";
            this.bancoProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // epConsultarRua
            // 
            this.epConsultarRua.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epConsultarRua.ContainerControl = this;
            this.epConsultarRua.Icon = ((System.Drawing.Icon)(resources.GetObject("epConsultarRua.Icon")));
            // 
            // bancoProjetoMADataSet
            // 
            this.bancoProjetoMADataSet.DataSetName = "bancoProjetoMADataSet";
            this.bancoProjetoMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisarRuaConsulta
            // 
            this.txtPesquisarRuaConsulta.Location = new System.Drawing.Point(6, 32);
            this.txtPesquisarRuaConsulta.Name = "txtPesquisarRuaConsulta";
            this.txtPesquisarRuaConsulta.Size = new System.Drawing.Size(445, 22);
            this.txtPesquisarRuaConsulta.TabIndex = 7;
            this.txtPesquisarRuaConsulta.TextChanged += new System.EventHandler(this.txtPesquisarRuaConsulta_TextChanged);
            // 
            // dgvConsultaRua
            // 
            this.dgvConsultaRua.AllowUserToAddRows = false;
            this.dgvConsultaRua.AllowUserToResizeRows = false;
            this.dgvConsultaRua.AutoGenerateColumns = false;
            this.dgvConsultaRua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaRua.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvConsultaRua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaRua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idruaDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.qntdCasasDataGridViewTextBoxColumn,
            this.qntdArvoresDataGridViewTextBoxColumn});
            this.dgvConsultaRua.DataSource = this.ruasBindingSource;
            this.dgvConsultaRua.Location = new System.Drawing.Point(6, 58);
            this.dgvConsultaRua.Name = "dgvConsultaRua";
            this.dgvConsultaRua.ReadOnly = true;
            this.dgvConsultaRua.RowHeadersVisible = false;
            this.dgvConsultaRua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaRua.Size = new System.Drawing.Size(708, 221);
            this.dgvConsultaRua.TabIndex = 34;
            this.dgvConsultaRua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaRua_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome";
            // 
            // gpbPesquisarRua
            // 
            this.gpbPesquisarRua.Controls.Add(this.label1);
            this.gpbPesquisarRua.Controls.Add(this.dgvConsultaRua);
            this.gpbPesquisarRua.Controls.Add(this.txtPesquisarRuaConsulta);
            this.gpbPesquisarRua.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarRua.Location = new System.Drawing.Point(13, 210);
            this.gpbPesquisarRua.Name = "gpbPesquisarRua";
            this.gpbPesquisarRua.Size = new System.Drawing.Size(720, 285);
            this.gpbPesquisarRua.TabIndex = 35;
            this.gpbPesquisarRua.TabStop = false;
            this.gpbPesquisarRua.Text = "Pesquisar Rua";
            // 
            // ruasBindingSource
            // 
            this.ruasBindingSource.DataMember = "ruas";
            this.ruasBindingSource.DataSource = this.bancoProjetoDataSet;
            // 
            // ruasTableAdapter
            // 
            this.ruasTableAdapter.ClearBeforeFill = true;
            // 
            // idruaDataGridViewTextBoxColumn
            // 
            this.idruaDataGridViewTextBoxColumn.DataPropertyName = "id_rua";
            this.idruaDataGridViewTextBoxColumn.HeaderText = "id_rua";
            this.idruaDataGridViewTextBoxColumn.Name = "idruaDataGridViewTextBoxColumn";
            this.idruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qntdCasasDataGridViewTextBoxColumn
            // 
            this.qntdCasasDataGridViewTextBoxColumn.DataPropertyName = "qntdCasas";
            this.qntdCasasDataGridViewTextBoxColumn.HeaderText = "qntdCasas";
            this.qntdCasasDataGridViewTextBoxColumn.Name = "qntdCasasDataGridViewTextBoxColumn";
            this.qntdCasasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qntdArvoresDataGridViewTextBoxColumn
            // 
            this.qntdArvoresDataGridViewTextBoxColumn.DataPropertyName = "qntdArvores";
            this.qntdArvoresDataGridViewTextBoxColumn.HeaderText = "qntdArvores";
            this.qntdArvoresDataGridViewTextBoxColumn.Name = "qntdArvoresDataGridViewTextBoxColumn";
            this.qntdArvoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaRua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(745, 507);
            this.Controls.Add(this.gpbPesquisarRua);
            this.Controls.Add(this.grpConsultaRua);
            this.Controls.Add(this.toolStrip1);
            this.Name = "consultaRua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "consultaRua";
            this.Load += new System.EventHandler(this.consultaRua_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpConsultaRua.ResumeLayout(false);
            this.grpConsultaRua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConsultarRua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaRua)).EndInit();
            this.gpbPesquisarRua.ResumeLayout(false);
            this.gpbPesquisarRua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvarEdicao;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.TextBox txtQntdArvores;
        private System.Windows.Forms.Label label_QntdArvores;
        private System.Windows.Forms.TextBox txtQntdCasas;
        private System.Windows.Forms.Label label_QntdCasas;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label_Cidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label_Bairro;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label_Cep;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label_Endereco;
        private System.Windows.Forms.TextBox txtIdRua;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.GroupBox grpConsultaRua;
        private bancoProjetoDataSet bancoProjetoDataSet;
        private System.Windows.Forms.ErrorProvider epConsultarRua;
        private bancoProjetoMADataSet bancoProjetoMADataSet;
        private System.Windows.Forms.GroupBox gpbPesquisarRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsultaRua;
        private System.Windows.Forms.TextBox txtPesquisarRuaConsulta;
        private System.Windows.Forms.BindingSource ruasBindingSource;
        private bancoProjetoDataSetTableAdapters.ruasTableAdapter ruasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntdCasasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntdArvoresDataGridViewTextBoxColumn;
    }
}