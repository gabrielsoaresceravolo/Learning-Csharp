using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{//              classe derivada : classe base
    internal class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public int Cpf { get; set; }

        public ClienteFisico(int codigo, string nome, string endereco, int rg, int cpf) : base(codigo, nome, endereco)
        {
            Rg = rg;
            Cpf = cpf;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"RG: {Rg} \tCPF: {Cpf}");
        }
    }
}
