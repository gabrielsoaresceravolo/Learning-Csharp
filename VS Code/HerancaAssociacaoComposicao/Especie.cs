using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaAssociacaoComposicao
{
    public class Especie : Pagamento
    {
        // Especie é uma subclasse do PAGAMENTO então devo colocar : e o nome da base

        private double quantia;
        private double troco;
    }
}