namespace Financeiro
{
    partial class frmPrincipal
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRendaDiaria = new System.Windows.Forms.TabPage();
            this.btnLancar = new System.Windows.Forms.Button();
            this.lblCartao = new System.Windows.Forms.Label();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblDataLancamento = new System.Windows.Forms.Label();
            this.dgvRendaDiaria = new System.Windows.Forms.DataGridView();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.dtDataLancamento = new System.Windows.Forms.DateTimePicker();
            this.tabDespesaMensal = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvDespesaMensal = new System.Windows.Forms.DataGridView();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.cbTipoPagamento = new System.Windows.Forms.ComboBox();
            this.cbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.btnLancarDespesa = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabRelatorioDespesa = new System.Windows.Forms.TabPage();
            this.dgvRelatorioDespesa = new System.Windows.Forms.DataGridView();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnExibirRelatorioDespesa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabRendaDiaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaDiaria)).BeginInit();
            this.tabDespesaMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesaMensal)).BeginInit();
            this.tabRelatorioDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabRendaDiaria);
            this.tabControl.Controls.Add(this.tabDespesaMensal);
            this.tabControl.Controls.Add(this.tabRelatorioDespesa);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 561);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabRendaDiaria
            // 
            this.tabRendaDiaria.Controls.Add(this.btnLancar);
            this.tabRendaDiaria.Controls.Add(this.lblCartao);
            this.tabRendaDiaria.Controls.Add(this.lblDinheiro);
            this.tabRendaDiaria.Controls.Add(this.lblDataLancamento);
            this.tabRendaDiaria.Controls.Add(this.dgvRendaDiaria);
            this.tabRendaDiaria.Controls.Add(this.txtCartao);
            this.tabRendaDiaria.Controls.Add(this.txtDinheiro);
            this.tabRendaDiaria.Controls.Add(this.dtDataLancamento);
            this.tabRendaDiaria.Location = new System.Drawing.Point(4, 25);
            this.tabRendaDiaria.Name = "tabRendaDiaria";
            this.tabRendaDiaria.Padding = new System.Windows.Forms.Padding(3);
            this.tabRendaDiaria.Size = new System.Drawing.Size(776, 532);
            this.tabRendaDiaria.TabIndex = 0;
            this.tabRendaDiaria.Text = "Renda Diária";
            this.tabRendaDiaria.UseVisualStyleBackColor = true;
            // 
            // btnLancar
            // 
            this.btnLancar.Location = new System.Drawing.Point(638, 30);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(130, 23);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(220, 17);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(38, 13);
            this.lblCartao.TabIndex = 7;
            this.lblCartao.Text = "Cartão";
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.Location = new System.Drawing.Point(114, 17);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(46, 13);
            this.lblDinheiro.TabIndex = 6;
            this.lblDinheiro.Text = "Dinheiro";
            // 
            // lblDataLancamento
            // 
            this.lblDataLancamento.AutoSize = true;
            this.lblDataLancamento.Location = new System.Drawing.Point(8, 17);
            this.lblDataLancamento.Name = "lblDataLancamento";
            this.lblDataLancamento.Size = new System.Drawing.Size(107, 13);
            this.lblDataLancamento.TabIndex = 5;
            this.lblDataLancamento.Text = "Data de Lançamento";
            // 
            // dgvRendaDiaria
            // 
            this.dgvRendaDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendaDiaria.Location = new System.Drawing.Point(8, 78);
            this.dgvRendaDiaria.Name = "dgvRendaDiaria";
            this.dgvRendaDiaria.Size = new System.Drawing.Size(760, 446);
            this.dgvRendaDiaria.TabIndex = 4;
            // 
            // txtCartao
            // 
            this.txtCartao.Location = new System.Drawing.Point(223, 33);
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(100, 20);
            this.txtCartao.TabIndex = 3;
            this.txtCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(117, 33);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(100, 20);
            this.txtDinheiro.TabIndex = 2;
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtDataLancamento
            // 
            this.dtDataLancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLancamento.Location = new System.Drawing.Point(11, 33);
            this.dtDataLancamento.Name = "dtDataLancamento";
            this.dtDataLancamento.Size = new System.Drawing.Size(100, 20);
            this.dtDataLancamento.TabIndex = 1;
            // 
            // tabDespesaMensal
            // 
            this.tabDespesaMensal.Controls.Add(this.btnNovo);
            this.tabDespesaMensal.Controls.Add(this.btnExcluir);
            this.tabDespesaMensal.Controls.Add(this.dgvDespesaMensal);
            this.tabDespesaMensal.Controls.Add(this.lblTipoPagamento);
            this.tabDespesaMensal.Controls.Add(this.lblTipoDespesa);
            this.tabDespesaMensal.Controls.Add(this.cbTipoPagamento);
            this.tabDespesaMensal.Controls.Add(this.cbTipoDespesa);
            this.tabDespesaMensal.Controls.Add(this.btnLancarDespesa);
            this.tabDespesaMensal.Controls.Add(this.lblValor);
            this.tabDespesaMensal.Controls.Add(this.lblDescricao);
            this.tabDespesaMensal.Controls.Add(this.lblDataVencimento);
            this.tabDespesaMensal.Controls.Add(this.txtValor);
            this.tabDespesaMensal.Controls.Add(this.txtDescricao);
            this.tabDespesaMensal.Controls.Add(this.dtDataVencimento);
            this.tabDespesaMensal.Location = new System.Drawing.Point(4, 25);
            this.tabDespesaMensal.Name = "tabDespesaMensal";
            this.tabDespesaMensal.Padding = new System.Windows.Forms.Padding(3);
            this.tabDespesaMensal.Size = new System.Drawing.Size(776, 532);
            this.tabDespesaMensal.TabIndex = 1;
            this.tabDespesaMensal.Text = "Despesa Mensal";
            this.tabDespesaMensal.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(638, 61);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvDespesaMensal
            // 
            this.dgvDespesaMensal.AllowUserToAddRows = false;
            this.dgvDespesaMensal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesaMensal.Location = new System.Drawing.Point(8, 90);
            this.dgvDespesaMensal.Name = "dgvDespesaMensal";
            this.dgvDespesaMensal.ReadOnly = true;
            this.dgvDespesaMensal.Size = new System.Drawing.Size(760, 434);
            this.dgvDespesaMensal.TabIndex = 20;
            this.dgvDespesaMensal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesaMensal_CellClick);
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(492, 17);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(100, 13);
            this.lblTipoPagamento.TabIndex = 19;
            this.lblTipoPagamento.Text = "Tipo de Pagamento";
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(386, 17);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDespesa.TabIndex = 18;
            this.lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // cbTipoPagamento
            // 
            this.cbTipoPagamento.FormattingEnabled = true;
            this.cbTipoPagamento.Items.AddRange(new object[] {
            "BOLETO",
            "CHEQUE",
            "DINHEIRO"});
            this.cbTipoPagamento.Location = new System.Drawing.Point(495, 32);
            this.cbTipoPagamento.Name = "cbTipoPagamento";
            this.cbTipoPagamento.Size = new System.Drawing.Size(100, 21);
            this.cbTipoPagamento.TabIndex = 5;
            // 
            // cbTipoDespesa
            // 
            this.cbTipoDespesa.FormattingEnabled = true;
            this.cbTipoDespesa.Items.AddRange(new object[] {
            "FIXA",
            "GERAL"});
            this.cbTipoDespesa.Location = new System.Drawing.Point(389, 32);
            this.cbTipoDespesa.Name = "cbTipoDespesa";
            this.cbTipoDespesa.Size = new System.Drawing.Size(100, 21);
            this.cbTipoDespesa.TabIndex = 4;
            // 
            // btnLancarDespesa
            // 
            this.btnLancarDespesa.Location = new System.Drawing.Point(638, 32);
            this.btnLancarDespesa.Name = "btnLancarDespesa";
            this.btnLancarDespesa.Size = new System.Drawing.Size(130, 23);
            this.btnLancarDespesa.TabIndex = 6;
            this.btnLancarDespesa.Text = "Lançar";
            this.btnLancarDespesa.UseVisualStyleBackColor = true;
            this.btnLancarDespesa.Click += new System.EventHandler(this.btnLancarDespesa_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(320, 17);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 14;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(114, 17);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Location = new System.Drawing.Point(8, 17);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(104, 13);
            this.lblDataVencimento.TabIndex = 12;
            this.lblDataVencimento.Text = "Data de Vencimento";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(323, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(60, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(117, 33);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(200, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // dtDataVencimento
            // 
            this.dtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataVencimento.Location = new System.Drawing.Point(11, 33);
            this.dtDataVencimento.Name = "dtDataVencimento";
            this.dtDataVencimento.Size = new System.Drawing.Size(100, 20);
            this.dtDataVencimento.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(638, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(130, 23);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tabRelatorioDespesa
            // 
            this.tabRelatorioDespesa.Controls.Add(this.label1);
            this.tabRelatorioDespesa.Controls.Add(this.btnExibirRelatorioDespesa);
            this.tabRelatorioDespesa.Controls.Add(this.dtDataFim);
            this.tabRelatorioDespesa.Controls.Add(this.dtDataInicio);
            this.tabRelatorioDespesa.Controls.Add(this.dgvRelatorioDespesa);
            this.tabRelatorioDespesa.Location = new System.Drawing.Point(4, 25);
            this.tabRelatorioDespesa.Name = "tabRelatorioDespesa";
            this.tabRelatorioDespesa.Size = new System.Drawing.Size(776, 532);
            this.tabRelatorioDespesa.TabIndex = 2;
            this.tabRelatorioDespesa.Text = "Despesa Mensal - Relatório";
            this.tabRelatorioDespesa.UseVisualStyleBackColor = true;
            // 
            // dgvRelatorioDespesa
            // 
            this.dgvRelatorioDespesa.AllowUserToAddRows = false;
            this.dgvRelatorioDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioDespesa.Location = new System.Drawing.Point(8, 62);
            this.dgvRelatorioDespesa.Name = "dgvRelatorioDespesa";
            this.dgvRelatorioDespesa.ReadOnly = true;
            this.dgvRelatorioDespesa.Size = new System.Drawing.Size(760, 462);
            this.dgvRelatorioDespesa.TabIndex = 21;
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataInicio.Location = new System.Drawing.Point(8, 23);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(100, 20);
            this.dtDataInicio.TabIndex = 22;
            // 
            // dtDataFim
            // 
            this.dtDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFim.Location = new System.Drawing.Point(114, 23);
            this.dtDataFim.Name = "dtDataFim";
            this.dtDataFim.Size = new System.Drawing.Size(100, 20);
            this.dtDataFim.TabIndex = 23;
            // 
            // btnExibirRelatorioDespesa
            // 
            this.btnExibirRelatorioDespesa.Location = new System.Drawing.Point(638, 20);
            this.btnExibirRelatorioDespesa.Name = "btnExibirRelatorioDespesa";
            this.btnExibirRelatorioDespesa.Size = new System.Drawing.Size(130, 23);
            this.btnExibirRelatorioDespesa.TabIndex = 24;
            this.btnExibirRelatorioDespesa.Text = "Exibir";
            this.btnExibirRelatorioDespesa.UseVisualStyleBackColor = true;
            this.btnExibirRelatorioDespesa.Click += new System.EventHandler(this.btnExibirRelatorioDespesa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Período";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Financeiro";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRendaDiaria.ResumeLayout(false);
            this.tabRendaDiaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendaDiaria)).EndInit();
            this.tabDespesaMensal.ResumeLayout(false);
            this.tabDespesaMensal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesaMensal)).EndInit();
            this.tabRelatorioDespesa.ResumeLayout(false);
            this.tabRelatorioDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDespesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRendaDiaria;
        private System.Windows.Forms.TabPage tabDespesaMensal;
        private System.Windows.Forms.Label lblCartao;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblDataLancamento;
        private System.Windows.Forms.DataGridView dgvRendaDiaria;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.DateTimePicker dtDataLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnLancarDespesa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dtDataVencimento;
        private System.Windows.Forms.ComboBox cbTipoPagamento;
        private System.Windows.Forms.ComboBox cbTipoDespesa;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.DataGridView dgvDespesaMensal;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabPage tabRelatorioDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExibirRelatorioDespesa;
        private System.Windows.Forms.DateTimePicker dtDataFim;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.DataGridView dgvRelatorioDespesa;
    }
}