using System;

namespace Financeiro.Model
{
    public class RelatorioDespesaMensal
    {
        public DateTime DataVencimento { get; set; }
        public string DiaSemana { get; set; }
        public decimal Valor { get; set; }
    }
}
