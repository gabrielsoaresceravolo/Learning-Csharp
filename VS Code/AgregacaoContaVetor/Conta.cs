using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    internal class Conta
    {
        public int Numero { get; set; }
        //<> generics
        public List<Cliente> VetTitular { get; set; }
        public double Saldo { get; set; }

        public void ListarClientesFor()
        {//Cout é a propriedade que informa quantos elementos tem no vetor
            Console.WriteLine("Número: " + Numero + "\tSaldo: " + Saldo);
            for (int i = 0; i < VetTitular.Count; i++)
                VetTitular[i].Mostrar();

        }
        // ou desta forma
        public void ListarClientesForeach()
        {
            Console.WriteLine("Número: " + Numero + "\tSaldo: " + Saldo);
            foreach (Cliente cliente in VetTitular)
                cliente.Mostrar();
        }
    }
}
