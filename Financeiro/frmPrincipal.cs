using Financeiro.Helper;
using System;
using System.Windows.Forms;

namespace Financeiro
{
    public partial class frmPrincipal : Form
    {
        int despesaMensalId;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            PreencheGridRendaDiaria();
            PreencheGridDespesaMensal();
        }

        private void btnLancarDespesa_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text) ||
                string.IsNullOrEmpty(txtValor.Text) ||
                cbTipoDespesa.SelectedIndex < 0 ||
                cbTipoPagamento.SelectedIndex < 0)
            {
                MessageBox.Show("É obrigatório informar todos os dados.");
            }
            else
            {
                string dataVencimento = dtDataVencimento.Value.ToString("yyyyMMdd");
                string descricao = txtDescricao.Text;
                decimal valor = decimal.Parse(txtValor.Text);
                int tipoDespesa = cbTipoDespesa.SelectedIndex;
                int tipoPagamento = cbTipoPagamento.SelectedIndex;

                if (despesaMensalId > 0)
                {
                    SQLiteHelper.OpenConnection();
                    SQLiteHelper.UpdateDespesaMensal(dataVencimento, descricao, valor, tipoDespesa, tipoPagamento, despesaMensalId);
                    SQLiteHelper.CloseConnection();
                }
                else
                {
                    SQLiteHelper.OpenConnection();
                    SQLiteHelper.InsertDespesaMensal(dataVencimento, descricao, valor, tipoDespesa, tipoPagamento);
                    SQLiteHelper.CloseConnection();
                }

                LimpaCamposDespesaMensal();

                PreencheGridDespesaMensal();
            }
        }

        private void LimpaCamposDespesaMensal()
        {
            despesaMensalId = 0;
            dtDataVencimento.Value = DateTime.Now;
            txtDescricao.Text = "";
            txtValor.Text = "";
            cbTipoDespesa.SelectedIndex = -1;
            cbTipoPagamento.SelectedIndex = -1;
        }

        private void btnLancar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDinheiro.Text) && string.IsNullOrEmpty(txtCartao.Text))
            {
                MessageBox.Show("É obrigatório informar ao menos um meio de pagamento.");
            }
            else
            {
                string dataMovimento = dtDataLancamento.Value.ToString("yyyyMMdd");
                decimal valorDinheiro = string.IsNullOrEmpty(txtDinheiro.Text) ? 0 : decimal.Parse(txtDinheiro.Text);
                decimal valorCartao = string.IsNullOrEmpty(txtCartao.Text) ? 0 : decimal.Parse(txtCartao.Text);
                SQLiteHelper.OpenConnection();
                SQLiteHelper.InsertRendaDiaria(dataMovimento, valorDinheiro, valorCartao);
                SQLiteHelper.CloseConnection();

                txtCartao.Text = "";
                txtDinheiro.Text = "";

                PreencheGridRendaDiaria();
            }
        }

        private void PreencheGridRendaDiaria()
        {
            SQLiteHelper.OpenConnection();
            dgvRendaDiaria.DataSource = SQLiteHelper.SelectRendaDiaria();
            dgvRendaDiaria.Columns[0].ReadOnly = true;
            SQLiteHelper.CloseConnection();
        }

        private void PreencheGridDespesaMensal()
        {
            SQLiteHelper.OpenConnection();
            dgvDespesaMensal.DataSource = SQLiteHelper.SelectDespesaMensal();
            dgvDespesaMensal.Columns[0].ReadOnly = true;
            SQLiteHelper.CloseConnection();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (despesaMensalId > 0)
            {
                SQLiteHelper.OpenConnection();
                SQLiteHelper.DeleteDespesaMensal(despesaMensalId);
                SQLiteHelper.CloseConnection();

                LimpaCamposDespesaMensal();

                PreencheGridDespesaMensal();
            }
        }

        private void dgvDespesaMensal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            despesaMensalId = int.Parse(dgvDespesaMensal.Rows[e.RowIndex].Cells[0].Value.ToString());
            SQLiteHelper.OpenConnection();
            var despesaMensal = SQLiteHelper.SelectDespesaMensalPorId(despesaMensalId);
            SQLiteHelper.CloseConnection();

            dtDataVencimento.Value = despesaMensal.DataVencimento;
            txtDescricao.Text = despesaMensal.Descricao;
            txtValor.Text = despesaMensal.Valor.ToString("");
            cbTipoDespesa.SelectedItem = despesaMensal.TipoDespesa;
            cbTipoPagamento.SelectedItem = despesaMensal.TipoPagamento;
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            LimpaCamposDespesaMensal();
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                dtDataInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtDataFim.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                btnExibirRelatorioDespesa_Click(sender, e);
            }
        }

        private void btnExibirRelatorioDespesa_Click(object sender, EventArgs e)
        {
            SQLiteHelper.OpenConnection();
            dgvRelatorioDespesa.DataSource = SQLiteHelper.SelectRelatorioDespesaMensal(dtDataInicio.Value, dtDataFim.Value);
            SQLiteHelper.CloseConnection();
        }
    }
}
