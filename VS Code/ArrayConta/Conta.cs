using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        public int numero;
        public string titular = "";
        public double saldo;

        public void Mostrar()
        {
            Console.WriteLine("Número: " + numero +
                     "\tTitular: " + titular + "\tSaldo: " + saldo);
        }
        public void Reajustar()
        {

        }
    }
}