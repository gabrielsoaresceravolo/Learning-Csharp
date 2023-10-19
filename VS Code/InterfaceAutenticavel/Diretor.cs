using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public Diretor(int senha) : base (senha)
        {

        }

        bool Autentica(int senha)
        {
            if(this.Senha == senha)
            {
                Console.WriteLine("O diretor acessou o sistema");
                return true;
            }
            else
            {
                Console.WriteLine("O diretor não acessou o sistema");
                return false;
            }
        }
    }
}