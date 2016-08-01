using System;

namespace Financeiro.Model
{
    public class RendaDiaria
    {
        public DateTime DataMovimento { get; set; }
        public decimal ValorDinheiro { get; set; }
        public decimal ValorCartao { get; set; }
    }
}
