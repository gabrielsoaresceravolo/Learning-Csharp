using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    // Não significa herança e sim implementação da interface IAutenticavel
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }

        public Cliente(int senha)
        {
            this.Senha = senha;
        }

        bool Autentica(int senha)
        {
            if(this.Senha == senha)
            {
                Console.WriteLine("O Cliente acessou o sistema");
                return true;
            }
            else
            {
                Console.WriteLine("O Cliente não acessou o sistema");
                return false;
            }
        }
    }
}