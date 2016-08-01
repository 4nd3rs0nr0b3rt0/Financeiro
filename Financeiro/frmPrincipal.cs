using Financeiro.Helper;
using Financeiro.Model;
using System.Windows.Forms;

namespace Financeiro
{
    public partial class frmPrincipal : Form
    {
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
                SQLiteHelper.OpenConnection();
                SQLiteHelper.InsertDespesaMensal(dataVencimento, descricao, valor, tipoDespesa, tipoPagamento);
                SQLiteHelper.CloseConnection();

                txtDescricao.Text = "";
                txtValor.Text = "";
                cbTipoDespesa.SelectedIndex = -1;
                cbTipoPagamento.SelectedIndex = -1;

                PreencheGridDespesaMensal();
            }
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
            SQLiteHelper.CloseConnection();
        }

        private void PreencheGridDespesaMensal()
        {
            SQLiteHelper.OpenConnection();
            dgvDespesaMensal.DataSource = SQLiteHelper.SelectDespesaMensal();
            SQLiteHelper.CloseConnection();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (dgvDespesaMensal.SelectedRows.Count == 1)
            {
                SQLiteHelper.OpenConnection();
                var row = dgvDespesaMensal.SelectedRows[0].DataBoundItem as DespesaMensal;
                string dataVencimento = row.DataVencimento.ToString("yyyyMMdd");
                string descricao = row.Descricao;
                decimal valor = row.Valor;
                int tipoDespesa = row.TipoDespesa == "FIXA" ? 0 : 1;
                int tipoPagamento = row.TipoPagamento == "BOLETO" ? 0 : row.TipoPagamento == "CHEQUE" ? 1 : 2;
                SQLiteHelper.DeleteDespesaMensal(dataVencimento, descricao, valor, tipoDespesa, tipoPagamento);
                SQLiteHelper.CloseConnection();

                PreencheGridDespesaMensal();
            }
        }
    }
}
