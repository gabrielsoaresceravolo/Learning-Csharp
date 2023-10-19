using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataDepartamento
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (var funcionario in Funcionarios)
            {
                Console.WriteLine($"Funcionário: {funcionario.Nome}, Dependentes: {funcionario.CalcularTotalDependente()}");
            }
        }

        public double CalcularFolhaPagamento(int diasUteis)
        {
            double folhaPagamento = 0;

            foreach (var funcionario in Funcionarios)
            {
                folhaPagamento += funcionario.CalcularSalario(diasUteis);
            }
            return folhaPagamento;
        }

        public void AdmitirFuncionario(Funcionario novoFuncionario)
        {
            Funcionarios.Add(novoFuncionario);
        }

        public void DemitirFuncionario(int codigoDoFuncionario)
        {
            Funcionarios.RemoveAll(f => f.Codigo == codigoDoFuncionario);
        }

        public List<Funcionario> ListarNomeFuncionarioESalarioFixo()
        {
            return Funcionarios.FindAll(f => f.Salario > 0);
        }
    }
}