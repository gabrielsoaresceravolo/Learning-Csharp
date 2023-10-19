using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    internal class Conta
    {
        //private -> encapsulamento
        private int numero;
        private string titular="";
        //private double saldo;
        public double Saldo { get; private set; }
        public void Depositar(double valorDeposito)
        {// set saldo = parâmetro
            //Saldo += valorDeposito;
            Saldo = Saldo + valorDeposito;
        }

        public string Titular //propriedade
        {
            set { titular = value; } //altera valor
            get { return titular; } //busca valor                    
        }
        //métodos de encapsulamento
        public void SetNumero(int numero) 
        {
            this.numero = numero;    
        }
        public int GetNumero()
        { 
            return this.numero; 
        }

    }
}
