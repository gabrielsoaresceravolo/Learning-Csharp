using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        //método construtor
        public Conta() //construtor padrão
        {
        }
        public Conta(int numero)
        {
            Numero = numero;
        }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + Numero +
                            "\tTitular: " + Titular +
                            "\tSaldo: " + Saldo);
        }
    }
}
