using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataDepartamento
{
    public abstract class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        
        public List<Dependente> Dependentes { get; set; } = new List<Dependente>();

        public int CalcularTotalDependente()
        {
            return Dependentes.Count;
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            Dependentes.Add(novoDep);
        }

        public void RemoverDependentesMaioridade()
        {
            Dependentes.RemoveAll(d => d.VerificarMaioridade());
        }

        public void ListarDependentes()
        {
            foreach (var dependente in Dependentes)
            {
                Console.WriteLine($"Nome: {dependente.Nome}, Idade: {dependente.Idade}");
            }
        }

        public abstract double CalcularSalario(int diasUteis);
    }
}