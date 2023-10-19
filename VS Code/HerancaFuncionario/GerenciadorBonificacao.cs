using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double bonificacaototal;

        public double TotalBonificacao
        {
            get { return bonificacaototal; }
            private set { bonificacaototal = value; }
        }

        public void TotalizarBonificacao(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizarBonificacao(Secretario secretario)
        {
            TotalBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizarBonificacao(Gerente gerente)
        {
            TotalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizarBonificacao(Diretor diretor)
        {
            TotalBonificacao += diretor.CalcularBonificacao();
        }
    }
}
