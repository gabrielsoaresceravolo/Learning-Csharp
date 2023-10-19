using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public string Cidade { get; set; }
        public Cliente()
        {//construtor padrão
        }
        public Cliente(string nome, string endereco, int telefone, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cidade = cidade;
        }
        public void Mostrar()
        {
            Console.WriteLine("Nome: "+ Nome +
                "\tEndereço: " + Endereco +
                "\tTelefone: " + Telefone +
                "\tCidade: " + Cidade);
        }

    }
}
