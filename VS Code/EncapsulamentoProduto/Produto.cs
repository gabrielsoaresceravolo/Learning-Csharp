using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoProduto
{
    internal class Produto
    {
        // declaração de atributos
        private int codigo;
        private string nome= "";
        private double preco;
        //declaração dad funções/métodos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public double Preco
        {
            get { return preco; }
            set {
                if (value >= 0)
                    preco = value; 
                else
                    Console.WriteLine("Preço inválido");
            }
        }
        //public int MyProperty { get; set; }
    }
}
