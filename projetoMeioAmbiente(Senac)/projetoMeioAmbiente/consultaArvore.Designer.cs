namespace projetoMeioAmbiente
{
    partial class consultaArvore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultaArvore));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarEdicao = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisaArvore = new System.Windows.Forms.TextBox();
            this.dgvConsultaArvore = new System.Windows.Forms.DataGridView();
            this.idarvoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoArvoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projecaoSombraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perimetroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arvoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoProjetoDataSet = new projetoMeioAmbiente.bancoProjetoDataSet();
            this.bancoProjetoMADataSet = new projetoMeioAmbiente.bancoProjetoMADataSet();
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
            this.label_idArvore = new System.Windows.Forms.Label();
            this.txtIdArvore = new System.Windows.Forms.TextBox();
            this.gbxConsultaArvore = new System.Windows.Forms.GroupBox();
            this.gbxConsultarArvore = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.mskGps = new System.Windows.Forms.MaskedTextBox();
            this.epConsultaArvore = new System.Windows.Forms.ErrorProvider(this.components);
            this.arvoresTableAdapter = new projetoMeioAmbiente.bancoProjetoDataSetTableAdapters.arvoresTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaArvore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).BeginInit();
            this.gbxConsultaArvore.SuspendLayout();
            this.gbxConsultarArvore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epConsultaArvore)).BeginInit();
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
            this.toolStrip1.TabIndex = 0;
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
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click_1);
            // 
            // txtPesquisaArvore
            // 
            this.txtPesquisaArvore.Location = new System.Drawing.Point(6, 19);
            this.txtPesquisaArvore.Name = "txtPesquisaArvore";
            this.txtPesquisaArvore.Size = new System.Drawing.Size(445, 22);
            this.txtPesquisaArvore.TabIndex = 7;
            this.txtPesquisaArvore.TextChanged += new System.EventHandler(this.txtPesquisaArvore_TextChanged);
            // 
            // dgvConsultaArvore
            // 
            this.dgvConsultaArvore.AllowUserToAddRows = false;
            this.dgvConsultaArvore.AllowUserToDeleteRows = false;
            this.dgvConsultaArvore.AllowUserToResizeRows = false;
            this.dgvConsultaArvore.AutoGenerateColumns = false;
            this.dgvConsultaArvore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaArvore.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvConsultaArvore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaArvore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idarvoreDataGridViewTextBoxColumn,
            this.idruaDataGridViewTextBoxColumn,
            this.especieDataGridViewTextBoxColumn,
            this.numeroCasaDataGridViewTextBoxColumn,
            this.tipoArvoreDataGridViewTextBoxColumn,
            this.projecaoSombraDataGridViewTextBoxColumn,
            this.perimetroDataGridViewTextBoxColumn,
            this.gpsDataGridViewTextBoxColumn});
            this.dgvConsultaArvore.DataSource = this.arvoresBindingSource;
            this.dgvConsultaArvore.Location = new System.Drawing.Point(6, 45);
            this.dgvConsultaArvore.Name = "dgvConsultaArvore";
            this.dgvConsultaArvore.ReadOnly = true;
            this.dgvConsultaArvore.RowHeadersVisible = false;
            this.dgvConsultaArvore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaArvore.Size = new System.Drawing.Size(708, 234);
            this.dgvConsultaArvore.TabIndex = 53;
            this.dgvConsultaArvore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaArvore_CellClick);
            // 
            // idarvoreDataGridViewTextBoxColumn
            // 
            this.idarvoreDataGridViewTextBoxColumn.DataPropertyName = "id_arvore";
            this.idarvoreDataGridViewTextBoxColumn.HeaderText = "id_arvore";
            this.idarvoreDataGridViewTextBoxColumn.Name = "idarvoreDataGridViewTextBoxColumn";
            this.idarvoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idruaDataGridViewTextBoxColumn
            // 
            this.idruaDataGridViewTextBoxColumn.DataPropertyName = "id_rua";
            this.idruaDataGridViewTextBoxColumn.HeaderText = "id_rua";
            this.idruaDataGridViewTextBoxColumn.Name = "idruaDataGridViewTextBoxColumn";
            this.idruaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // especieDataGridViewTextBoxColumn
            // 
            this.especieDataGridViewTextBoxColumn.DataPropertyName = "especie";
            this.especieDataGridViewTextBoxColumn.HeaderText = "especie";
            this.especieDataGridViewTextBoxColumn.Name = "especieDataGridViewTextBoxColumn";
            this.especieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCasaDataGridViewTextBoxColumn
            // 
            this.numeroCasaDataGridViewTextBoxColumn.DataPropertyName = "numeroCasa";
            this.numeroCasaDataGridViewTextBoxColumn.HeaderText = "numeroCasa";
            this.numeroCasaDataGridViewTextBoxColumn.Name = "numeroCasaDataGridViewTextBoxColumn";
            this.numeroCasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoArvoreDataGridViewTextBoxColumn
            // 
            this.tipoArvoreDataGridViewTextBoxColumn.DataPropertyName = "tipoArvore";
            this.tipoArvoreDataGridViewTextBoxColumn.HeaderText = "tipoArvore";
            this.tipoArvoreDataGridViewTextBoxColumn.Name = "tipoArvoreDataGridViewTextBoxColumn";
            this.tipoArvoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projecaoSombraDataGridViewTextBoxColumn
            // 
            this.projecaoSombraDataGridViewTextBoxColumn.DataPropertyName = "projecaoSombra";
            this.projecaoSombraDataGridViewTextBoxColumn.HeaderText = "projecaoSombra";
            this.projecaoSombraDataGridViewTextBoxColumn.Name = "projecaoSombraDataGridViewTextBoxColumn";
            this.projecaoSombraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perimetroDataGridViewTextBoxColumn
            // 
            this.perimetroDataGridViewTextBoxColumn.DataPropertyName = "perimetro";
            this.perimetroDataGridViewTextBoxColumn.HeaderText = "perimetro";
            this.perimetroDataGridViewTextBoxColumn.Name = "perimetroDataGridViewTextBoxColumn";
            this.perimetroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpsDataGridViewTextBoxColumn
            // 
            this.gpsDataGridViewTextBoxColumn.DataPropertyName = "gps";
            this.gpsDataGridViewTextBoxColumn.HeaderText = "gps";
            this.gpsDataGridViewTextBoxColumn.Name = "gpsDataGridViewTextBoxColumn";
            this.gpsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arvoresBindingSource
            // 
            this.arvoresBindingSource.DataMember = "arvores";
            this.arvoresBindingSource.DataSource = this.bancoProjetoDataSet;
            // 
            // bancoProjetoDataSet
            // 
            this.bancoProjetoDataSet.DataSetName = "bancoProjetoDataSet";
            this.bancoProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoProjetoMADataSet
            // 
            this.bancoProjetoMADataSet.DataSetName = "bancoProjetoMADataSet";
            this.bancoProjetoMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_IdRua
            // 
            this.label_IdRua.AutoSize = true;
            this.label_IdRua.Location = new System.Drawing.Point(75, 35);
            this.label_IdRua.Name = "label_IdRua";
            this.label_IdRua.Size = new System.Drawing.Size(40, 13);
            this.label_IdRua.TabIndex = 65;
            this.label_IdRua.Text = "Id Rua";
            // 
            // txtIdRua
            // 
            this.txtIdRua.Location = new System.Drawing.Point(78, 48);
            this.txtIdRua.Name = "txtIdRua";
            this.txtIdRua.ReadOnly = true;
            this.txtIdRua.Size = new System.Drawing.Size(37, 22);
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
            this.label16.Location = new System.Drawing.Point(196, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 62;
            this.label16.Text = "GPS";
            // 
            // label_dap
            // 
            this.label_dap.AutoSize = true;
            this.label_dap.Location = new System.Drawing.Point(196, 73);
            this.label_dap.Name = "label_dap";
            this.label_dap.Size = new System.Drawing.Size(166, 13);
            this.label_dap.TabIndex = 61;
            this.label_dap.Text = "Perímetro Altura do Peito (DAP)";
            // 
            // label_projeçãoSombra
            // 
            this.label_projeçãoSombra.AutoSize = true;
            this.label_projeçãoSombra.Location = new System.Drawing.Point(4, 73);
            this.label_projeçãoSombra.Name = "label_projeçãoSombra";
            this.label_projeçãoSombra.Size = new System.Drawing.Size(93, 13);
            this.label_projeçãoSombra.TabIndex = 60;
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
            this.label_TipoArvore.Size = new System.Drawing.Size(81, 13);
            this.label_TipoArvore.TabIndex = 58;
            this.label_TipoArvore.Text = "Tipo da Árvore";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(337, 48);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(60, 22);
            this.txtNumeroCasa.TabIndex = 2;
            this.txtNumeroCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(135, 48);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(181, 22);
            this.txtEspecie.TabIndex = 1;
            // 
            // label_NumeroCasa
            // 
            this.label_NumeroCasa.AutoSize = true;
            this.label_NumeroCasa.Location = new System.Drawing.Point(334, 35);
            this.label_NumeroCasa.Name = "label_NumeroCasa";
            this.label_NumeroCasa.Size = new System.Drawing.Size(63, 13);
            this.label_NumeroCasa.TabIndex = 57;
            this.label_NumeroCasa.Text = "Nº da Casa";
            // 
            // label_Especie
            // 
            this.label_Especie.AutoSize = true;
            this.label_Especie.Location = new System.Drawing.Point(132, 35);
            this.label_Especie.Name = "label_Especie";
            this.label_Especie.Size = new System.Drawing.Size(45, 13);
            this.label_Especie.TabIndex = 55;
            this.label_Especie.Text = "Espécie";
            // 
            // label_idArvore
            // 
            this.label_idArvore.AutoSize = true;
            this.label_idArvore.Location = new System.Drawing.Point(4, 35);
            this.label_idArvore.Name = "label_idArvore";
            this.label_idArvore.Size = new System.Drawing.Size(53, 13);
            this.label_idArvore.TabIndex = 69;
            this.label_idArvore.Text = "Id Árvore";
            // 
            // txtIdArvore
            // 
            this.txtIdArvore.Location = new System.Drawing.Point(7, 48);
            this.txtIdArvore.Name = "txtIdArvore";
            this.txtIdArvore.ReadOnly = true;
            this.txtIdArvore.Size = new System.Drawing.Size(50, 22);
            this.txtIdArvore.TabIndex = 0;
            // 
            // gbxConsultaArvore
            // 
            this.gbxConsultaArvore.Controls.Add(this.dgvConsultaArvore);
            this.gbxConsultaArvore.Controls.Add(this.txtPesquisaArvore);
            this.gbxConsultaArvore.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConsultaArvore.Location = new System.Drawing.Point(13, 210);
            this.gbxConsultaArvore.Name = "gbxConsultaArvore";
            this.gbxConsultaArvore.Size = new System.Drawing.Size(720, 285);
            this.gbxConsultaArvore.TabIndex = 72;
            this.gbxConsultaArvore.TabStop = false;
            this.gbxConsultaArvore.Text = "Pesquisar Árvore";
            // 
            // gbxConsultarArvore
            // 
            this.gbxConsultarArvore.Controls.Add(this.txtPerimetro);
            this.gbxConsultarArvore.Controls.Add(this.mskGps);
            this.gbxConsultarArvore.Controls.Add(this.txtEspecie);
            this.gbxConsultarArvore.Controls.Add(this.label_Especie);
            this.gbxConsultarArvore.Controls.Add(this.label_NumeroCasa);
            this.gbxConsultarArvore.Controls.Add(this.txtNumeroCasa);
            this.gbxConsultarArvore.Controls.Add(this.label_idArvore);
            this.gbxConsultarArvore.Controls.Add(this.label_TipoArvore);
            this.gbxConsultarArvore.Controls.Add(this.txtIdArvore);
            this.gbxConsultarArvore.Controls.Add(this.txtProjecaoSombra);
            this.gbxConsultarArvore.Controls.Add(this.label_IdRua);
            this.gbxConsultarArvore.Controls.Add(this.label_projeçãoSombra);
            this.gbxConsultarArvore.Controls.Add(this.txtIdRua);
            this.gbxConsultarArvore.Controls.Add(this.label_dap);
            this.gbxConsultarArvore.Controls.Add(this.cmbTipoArvore);
            this.gbxConsultarArvore.Controls.Add(this.label16);
            this.gbxConsultarArvore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConsultarArvore.Location = new System.Drawing.Point(13, 28);
            this.gbxConsultarArvore.Name = "gbxConsultarArvore";
            this.gbxConsultarArvore.Size = new System.Drawing.Size(420, 176);
            this.gbxConsultarArvore.TabIndex = 73;
            this.gbxConsultarArvore.TabStop = false;
            this.gbxConsultarArvore.Text = "Consultar Árvore";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(199, 87);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(198, 22);
            this.txtPerimetro.TabIndex = 4;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPerimetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerimetro_KeyPress);
            // 
            // mskGps
            // 
            this.mskGps.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskGps.Location = new System.Drawing.Point(199, 126);
            this.mskGps.Mask = "000000000";
            this.mskGps.Name = "mskGps";
            this.mskGps.Size = new System.Drawing.Size(198, 22);
            this.mskGps.TabIndex = 6;
            this.mskGps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // epConsultaArvore
            // 
            this.epConsultaArvore.BlinkRate = 500;
            this.epConsultaArvore.ContainerControl = this;
            this.epConsultaArvore.Icon = ((System.Drawing.Icon)(resources.GetObject("epConsultaArvore.Icon")));
            // 
            // arvoresTableAdapter
            // 
            this.arvoresTableAdapter.ClearBeforeFill = true;
            // 
            // consultaArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(745, 507);
            this.Controls.Add(this.gbxConsultarArvore);
            this.Controls.Add(this.gbxConsultaArvore);
            this.Controls.Add(this.toolStrip1);
            this.Name = "consultaArvore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Árvores";
            this.Load += new System.EventHandler(this.consultaArvore_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaArvore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arvoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoProjetoMADataSet)).EndInit();
            this.gbxConsultaArvore.ResumeLayout(false);
            this.gbxConsultaArvore.PerformLayout();
            this.gbxConsultarArvore.ResumeLayout(false);
            this.gbxConsultarArvore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epConsultaArvore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvarEdicao;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.TextBox txtPesquisaArvore;
        private System.Windows.Forms.DataGridView dgvConsultaArvore;
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
        private System.Windows.Forms.Label label_idArvore;
        private System.Windows.Forms.TextBox txtIdArvore;
        private System.Windows.Forms.GroupBox gbxConsultaArvore;
        private System.Windows.Forms.GroupBox gbxConsultarArvore;
        private System.Windows.Forms.MaskedTextBox mskGps;
        private bancoProjetoDataSet bancoProjetoDataSet;
        private System.Windows.Forms.TextBox txtPerimetro;
        private bancoProjetoMADataSet bancoProjetoMADataSet;
        private System.Windows.Forms.ErrorProvider epConsultaArvore;
        private System.Windows.Forms.BindingSource arvoresBindingSource;
        private bancoProjetoDataSetTableAdapters.arvoresTableAdapter arvoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarvoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoArvoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projecaoSombraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perimetroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsDataGridViewTextBoxColumn;
    }
}