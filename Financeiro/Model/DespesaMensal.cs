using System;

namespace Financeiro.Model
{
    public class DespesaMensal
    {
        public int DespesaMensalId { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string TipoDespesa { get; set; }
        public string TipoPagamento { get; set; }
    }

    public enum TipoDespesa
    {
        FIXA = 0,
        GERAL = 1
    }

    public enum TipoPagamento
    {
        BOLETO = 0,
        CHEQUE = 1,
        DINHEIRO = 2
    }
}
