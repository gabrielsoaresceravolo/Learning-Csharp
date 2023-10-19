using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    internal class Cliente //Classe base-superclasse
    {   // protected é o encapsulamento para a herança
        // e usado apenas na classe base

        protected int codigo;
        protected string nome;
        protected string endereco;

        public Cliente(int codigo, string nome, string endereco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome + "\tEndereço: " + endereco);
        }
    }
}
