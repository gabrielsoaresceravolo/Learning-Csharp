using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    internal class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public static int ContadorInstancias { get; set; }
        public Funcionario()
        {
            ContadorInstancias++;
        }

        public Funcionario(int codigo, string nome) 
        {
            Codigo = codigo;
            Nome = nome;
            ContadorInstancias++;
        } 
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            ContadorInstancias++;
        }
        public void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário: {Salario:C}");
        }
    }
}
