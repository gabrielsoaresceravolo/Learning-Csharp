using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    //CLASSE DERIVADA/SUBCLASS
    public class Diretor : Funcionario
    {
        public Diretor(string nome, double salario) : base(nome, salario)
        {

        }

        public override double CalcularBonificacao()
        {
            return base.CalcularBonificacao() + 1000;
        }
    }
}