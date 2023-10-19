using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração dos atributos
        public int numero;
        public string titular = "";
        public double saldo;

        //declaração dos métodos/funções
        public void Sacar(double valorSaque)
        {
            if (valorSaque <= saldo)
                saldo = saldo - valorSaque;
            else
                Console.WriteLine("Valor de saque inválido!");
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void Transferir(double valor, Conta objOutraConta)
        {
            saldo = saldo - valor;
            //outra conta
            objOutraConta.saldo = objOutraConta.saldo + valor;
        }
        public void Mostrar()
        {
            Console.WriteLine("Número: " + numero +
                "\tTitular: " + titular + "\tSaldo: " + saldo);
        }


    }
}