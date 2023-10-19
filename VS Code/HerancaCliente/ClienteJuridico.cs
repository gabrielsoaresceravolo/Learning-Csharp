using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{//                classe derivada : classe base
    internal class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public int Ie { get; set; } // inscrição estadual
        public ClienteJuridico(int codigo, string nome, string endereco,
            int cnpj, int ie) : base(codigo, nome, endereco)
        {
            Cnpj = cnpj;
            Ie = ie;    
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"CNPJ: {Cnpj} \tIe: {Ie}");
        }
    }
}
