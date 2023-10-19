using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataDepartamento
{
    public abstract class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

    }
}