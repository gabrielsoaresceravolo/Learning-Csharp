using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataDepartamento
{
    public class Assalariado : Funcionario
    {
        public override double CalcularSalario(int diasUteis)
        {
            return this.Salario / 30 * diasUteis;
        }
    }
}