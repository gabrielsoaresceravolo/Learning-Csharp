using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Funcionario
    {

        //CLASSE BASE/SUPERCLASS
        protected string nome;
        protected double salario;
        
        public Funcionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public virtual double CalcularBonificacao()
        {
            return salario * 15 / 100;
        }
    }
}