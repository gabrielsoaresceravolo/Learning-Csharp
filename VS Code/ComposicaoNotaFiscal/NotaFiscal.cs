using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    internal class NotaFiscal
    {
        public int Numero { get; set; }
        public string Data { get; set; }
        public List<ItemNotaFiscal> VetItens { get; set; }

        public NotaFiscal(int numero, string data, 
                          List<ItemNotaFiscal> vetItens)
        {
            Numero = numero;
            Data = data;
            VetItens = vetItens;
        }
        public NotaFiscal(int numero, string data)
        {
            Numero = numero;
            Data = data;
            VetItens = new List<ItemNotaFiscal>();
        }
    }
}
