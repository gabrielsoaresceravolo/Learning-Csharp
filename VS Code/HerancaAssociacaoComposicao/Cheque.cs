using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaAssociacaoComposicao
{
    public class Cheque : Pagamento
    {
        // Cheque é uma subclasse do PAGAMENTO então devo colocar : e o nome da base

        private long numero;
        private DateTime dataDeposito;
        private int situacao;
    }
}