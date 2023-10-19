using AbstrataDepartamento;

var departamento = new Departamento { Codigo = 1, Descricao = "RH" };
var Assalariado = new Assalariado { Codigo = 101, Nome = "João", Salario = 3000 };
var Comissionado = new Comissionado { Codigo = 102, Nome = "Maria", Salario = 2500, Vendas = 1000 };
// =======================

Assalariado.AdicionarDependente(new Dependente { Codigo = 201, Nome = "Pedro", Idade = 25 });
Assalariado.AdicionarDependente(new Dependente { Codigo = 202, Nome = "Ana", Idade = 17 });

departamento.AdmitirFuncionario(Assalariado);
departamento.AdmitirFuncionario(Comissionado);
// =======================

departamento.MostrarQtdeDependentesFuncionario();
Console.WriteLine($"Folha de Pagamento: {departamento.CalcularFolhaPagamento(22)}");

departamento.DemitirFuncionario(102);

Console.WriteLine("Funcionários com Salário Fixo:");
foreach (var funcionario in departamento.ListarNomeFuncionarioESalarioFixo())
{
    Console.WriteLine($"Nome: {funcionario.Nome}");
}
