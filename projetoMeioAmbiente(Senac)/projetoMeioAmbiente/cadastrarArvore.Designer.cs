namespace projetoMeioAmbiente
{
    partial class cadastrarArvore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrarArvore));
            this.label_IdRua = new System.Windows.Forms.Label();
            this.txtIdRua = new System.Windows.Forms.TextBox();
            this.cmbTipoArvore = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label_dap = new System.Windows.Forms.Label();
            this.label_projeçãoSombra = new System.Windows.Forms.Label();
            this.txtProjecaoSombra = new System.Windows.Forms.TextBox();
            this.label_TipoArvore = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label_NumeroCasa = new System.Windows.Forms.Label();
            this.label_Especie = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.dgvCadastroArvore = new System.Windows.Forms.DataGridView();
            this.bancoProjetoMADataSet = new projetoMeioAmbiente.bancoProjetoMADataSet();
            this.txtPesquisarRua = new System.Windows.Forms.TextBox();
            this.mskGps = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbCadastroArvore = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.epCadastrarArvore = new System.Windows.Forms.ErrorProvider(this.components);
            this.bancoProjetoDataSet = new projetoMeioAmbiente.bancoProjetoDataSet();
            this.ruasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruasTableAdapter = new projetoMeioAmbiente.bancoProjetoDataSetTableAdapters.ruasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroArvore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbCadastroArvore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCadastrarArvore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_IdRua
            // 
            this.label_IdRua.AutoSize = true;
            this.label_IdRua.Location = new System.Drawing.Point(4, 35);
            this.label_IdRua.Name = "label_IdRua";
            this.label_IdRua.Size = new System.Drawing.Size(39, 13);
            this.label_IdRua.TabIndex = 45;
            this.label_IdRua.Text = "Id Rua";
            // 
            // txtIdRua
            // 
            this.txtIdRua.Location = new System.Drawing.Point(7, 48);
            this.txtIdRua.Name = "txtIdRua";
            this.txtIdRua.ReadOnly = true;
            this.txtIdRua.Size = new System.Drawing.Size(38, 22);
            this.txtIdRua.TabIndex = 0;
            // 
            // cmbTipoArvore
            // 
            this.cmbTipoArvore.FormattingEnabled = true;
            this.cmbTipoArvore.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cmbTipoArvore.Location = new System.Drawing.Point(7, 126);
            this.cmbTipoArvore.Name = "cmbTipoArvore";
            this.cmbTipoArvore.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoArvore.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(196, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "GPS";
            // 
            // label_dap
            // 
            this.label_dap.AutoSize = true;
            this.label_dap.Location = new System.Drawing.Point(196, 73);
            this.label_dap.Name = "label_dap";
            this.label_dap.Size = new System.Drawing.Size(168, 13);
            this.label_dap.TabIndex = 40;
            this.label_dap.Text = "Perímetro Altura do Peito (DAP)";
            // 
            // label_projeçãoSombra
            // 
            this.label_projeçãoSombra.AutoSize = true;
            this.label_projeçãoSombra.Location = new System.Drawing.Point(4, 73);
            this.label_projeçãoSombra.Name = "label_projeçãoSombra";
            this.label_projeçãoSombra.Size = new System.Drawing.Size(94, 13);
            this.label_projeçãoSombra.TabIndex = 38;
            this.label_projeçãoSombra.Text = "Projeção Sombra";
            // 
            // txtProjecaoSombra
            // 
            this.txtProjecaoSombra.Location = new System.Drawing.Point(7, 87);
            this.txtProjecaoSombra.Name = "txtProjecaoSombra";
            this.txtProjecaoSombra.Size = new System.Drawing.Size(171, 22);
            this.txtProjecaoSombra.TabIndex = 3;
            this.txtProjecaoSombra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProjecaoSombra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProjecaoSombra_KeyPress);
            // 
            // label_TipoArvore
            // 
            this.label_TipoArvore.AutoSize = true;
            this.label_TipoArvore.Location = new System.Drawing.Point(4, 112);
            this.label_TipoArvore.Name = "label_TipoArvore";
            this.label_TipoArvore.Size = new System.Drawing.Size(83, 13);
            this.label_TipoArvore.TabIndex = 36;
            this.label_TipoArvore.Text = "Tipo da Árvore";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(310, 48);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(60, 22);
            this.txtNumeroCasa.TabIndex = 2;
            this.txtNumeroCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCasa_KeyPress);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(66, 48);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(223, 22);
            this.txtEspecie.TabIndex = 1;
            // 
            // label_NumeroCasa
            // 
            this.label_NumeroCasa.AutoSize = true;
            this.label_NumeroCasa.Location = new System.Drawing.Point(307, 35);
            this.label_NumeroCasa.Name = "label_NumeroCasa";
            this.label_NumeroCasa.Size = new System.Drawing.Size(63, 13);
            this.label_NumeroCasa.TabIndex = 35;
            this.label_NumeroCasa.Text = "Nº da Casa";
            // 
            // label_Especie
            // 
            this.label_Especie.AutoSize = true;
            this.label_Especie.Location = new System.Drawing.Point(63, 35);
            this.label_Especie.Name = "label_Especie";
            this.label_Especie.Size = new System.Drawing.Size(45, 13);
            this.label_Especie.TabIndex = 33;
            this.label_Especie.Text = "Espécie";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvar,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 46;
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
            // dgvCadastroArvore
            // 
            this.dgvCadastroArvore.AllowUserToAddRows = false;
            this.dgvCadastroArvore.AutoGenerateColumns = false;
            this.dgvCadastroArvore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCadastroArvore.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvCadastroArvore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroArvore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvCadastroArvore.DataSource = this.ruasBindingSource;
            this.dgvCadastroArvore.Enabled = false;
            this.dgvCadastroArvore.Location = new System.Drawing.Point(6, 45);
            this.dgvCadastroArvore.Name = "dgvCadastroArvore";
            this.dgvCadastroArvore.ReadOnly = true;
            this.dgvCadastroArvore.RowHeadersVisible = false;
            this.dgvCadastroArvore.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCadastroArvore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCadastroArvore.Size = new System.Drawing.Size(708, 234);
            this.dgvCadastroArvore.TabIndex = 47;
            this.dgvCadastroArvore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroArvore_CellClick);
            // 
            // bancoProjetoMADataSet
            // 
            this.bancoProjetoMADataSet.DataSetName = "bancoProjetoMADataSet";
            this.bancoProjetoMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisarRua
            // 
            this.txtPesquisarRua.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisarRua.Name = "txtPesquisarRua";
            this.txtPesquisarRua.Size = new System.Drawing.Size(445, 22);
            this.txtPesquisarRua.TabIndex = 7;
            this.txtPesquisarRua.TextChanged += new System.EventHandler(this.txtPesquisarRua_TextChanged);
            // 
            // mskGps
            // 
            this.mskGps.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskGps.Location = new System.Drawing.Point(199, 126);
            this.mskGps.Mask = "000000000";
            this.mskGps.Name = "mskGps";
            this.mskGps.Size = new System.Drawing.Size(171, 22);
            this.mskGps.TabIndex = 6;
            this.mskGps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCadastroArvore);
            this.groupBox1.Controls.Add(this.txtPesquisarRua);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 285);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Rua";
            // 
            // gpbCadastroArvore
            // 
            this.gpbCadastroArvore.Controls.Add(this.txtPerimetro);
            this.gpbCadastroArvore.Controls.Add(this.txtIdRua);
            this.gpbCadastroArvore.Controls.Add(this.label_Especie);
            this.gpbCadastroArvore.Controls.Add(this.label_NumeroCasa);
            this.gpbCadastroArvore.Controls.Add(this.mskGps);
            this.gpbCadastroArvore.Controls.Add(this.txtEspecie);
            this.gpbCadastroArvore.Controls.Add(this.txtNumeroCasa);
            this.gpbCadastroArvore.Controls.Add(this.label_TipoArvore);
            this.gpbCadastroArvore.Controls.Add(this.label_IdRua);
            this.gpbCadastroArvore.Controls.Add(this.txtProjecaoSombra);
            this.gpbCadastroArvore.Controls.Add(this.label_projeçãoSombra);
            this.gpbCadastroArvore.Controls.Add(this.cmbTipoArvore);
            this.gpbCadastroArvore.Controls.Add(this.label_dap);
            this.gpbCadastroArvore.Controls.Add(this.label16);
            this.gpbCadastroArvore.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastroArvore.Location = new System.Drawing.Point(12, 29);
            this.gpbCadastroArvore.Name = "gpbCadastroArvore";
            this.gpbCadastroArvore.Size = new System.Drawing.Size(396, 176);
            this.gpbCadastroArvore.TabIndex = 54;
            this.gpbCadastroArvore.TabStop = false;
            this.gpbCadastroArvore.Text = "Cadastrar Árvores";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(199, 87);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(171, 22);
            this.txtPerimetro.TabIndex = 4;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPerimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerimetro_KeyPress);
            // 
            // epCadastrarArvore
            // 
            this.epCadastrarArvore.BlinkRate = 500;
            this.epCadastrarArvore.ContainerControl = this;
            this.epCadastrarArvore.Icon = ((System.Drawing.Icon)(resources.GetObject("epCadastrarArvore.Icon")));
            // 
            // bancoProjetoDataSet
            // 
            this.bancoProjetoDataSet.DataSetName = "bancoProjetoDataSet";
            this.bancoProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_rua";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_rua";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "endereco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn2.HeaderText = "cep";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn4.HeaderText = "bairro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qntdCasas";
            this.dataGridViewTextBoxColumn6.HeaderText = "qntdCasas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qntdArvores";
            this.dataGridViewTextBoxColumn7.HeaderText = "qntdArvores";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cadastrarArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(745, 507);
            this.Controls.Add(this.gpbCadastroArvore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "cadastrarArvore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CADASTRAR ÁRVORE";
            this.Load += new System.EventHandler(this.cadastrarArvore_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroArvore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbCadastroArvore.ResumeLayout(false);
            this.gpbCadastroArvore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCadastrarArvore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_IdRua;
        private System.Windows.Forms.TextBox txtIdRua;
        private System.Windows.Forms.ComboBox cmbTipoArvore;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_dap;
        private System.Windows.Forms.Label label_projeçãoSombra;
        private System.Windows.Forms.TextBox txtProjecaoSombra;
        private System.Windows.Forms.Label label_TipoArvore;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label_NumeroCasa;
        private System.Windows.Forms.Label label_Especie;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.DataGridView dgvCadastroArvore;
        private System.Windows.Forms.TextBox txtPesquisarRua;
        private System.Windows.Forms.MaskedTextBox mskGps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbCadastroArvore;        
        private System.Windows.Forms.DataGridViewTextBoxColumn idruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntdCasasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntdArvoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.ErrorProvider epCadastrarArvore;
        private bancoProjetoMADataSet bancoProjetoMADataSet;
        private bancoProjetoDataSet bancoProjetoDataSet;
        private System.Windows.Forms.BindingSource ruasBindingSource;
        private bancoProjetoDataSetTableAdapters.ruasTableAdapter ruasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}