using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    internal class ItemNotaFiscal
    {
        public int Qtde { get; private set; }
        public ItemNotaFiscal(int qt)
        {
            Qtde = qt;
        }
        public void MostrarItem()
        {
            Console.WriteLine("Quantidade: " + Qtde);
        }
    }
}
