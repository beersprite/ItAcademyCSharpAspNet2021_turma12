using System;

namespace Laboratorio5cs
{
    public class ContaPoupanca : Conta
    {
        private decimal taxaJuros;
        private DateTime dataAniversario;
        public ContaPoupanca(string t, decimal j, DateTime d) : base(t)
        {
            taxaJuros = j;
            dataAniversario = d;
        }
        public decimal Juros
        {
            get { return taxaJuros; }
            set { taxaJuros = value; }
        }
        public DateTime DataAniversario
        {
            get { return dataAniversario; }
        }

        public void AdicionarRendimento()
        {
            DateTime hoje = DateTime.Now;
            if (hoje.Day == dataAniversario.Day && hoje.Month == dataAniversario.Month)
            {
                decimal rendimento = this.Saldo * taxaJuros;
                this.Depositar(rendimento);
            }
        }
        public override string Id
        {
            get { return $"{Titular}(CP)"; }
        }
    }
}