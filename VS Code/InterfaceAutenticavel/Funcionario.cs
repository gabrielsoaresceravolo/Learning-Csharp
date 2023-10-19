using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    // Classe Base
    public class Funcionario
    {
        public int Senha { get; set; }

        public Funcionario(int senha)
        {
            this.Senha = senha;
        }
    }
}