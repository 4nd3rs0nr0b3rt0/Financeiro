using System;

namespace Financeiro.Model
{
    public class RendaDiaria
    {
        public int RendaDiariaId { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal ValorDinheiro { get; set; }
        public decimal ValorCartao { get; set; }
    }
}
