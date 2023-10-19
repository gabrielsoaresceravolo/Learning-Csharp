using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaAssociacaoComposicao
{
    public class Cartao : Pagamento
    {
        // Cartao é uma subclasse do PAGAMENTO então devo colocar : e o nome da base

        private string dadosTransacao;
        private int resultadoTransacao;
    }
}