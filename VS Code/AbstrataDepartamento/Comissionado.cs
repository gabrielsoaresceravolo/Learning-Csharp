using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataDepartamento
{
    public class Comissionado : Funcionario
    {
        private const double PorcentagemComissao = 0.20;

        public double Vendas { get; set; }

        public override double CalcularSalario(int diasUteis)
        {
            double comissao = (Vendas * PorcentagemComissao) / 100;
            return this.Salario / 30 * diasUteis + comissao;
        }
    }
}