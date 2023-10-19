using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    //CLASSE DERIVADA/SUBCLASS
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        { 

        }

        public virtual double CalcularBonificacao()
        {
            return salario * 15 / 100;
        }

    }
}