using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    internal class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }//Agregação
        public double Saldo { get; set; }
    }
}
