//  Metodo Main() - Implicita
using HerancaFuncionario;

// =======================================================================================

Funcionario f = new Funcionario("Funcionario", 1000);
Console.WriteLine($"Valor da Bonificação: {f.CalcularBonificacao:c}");

Secretario s = new Secretario("Secretario", 1000);
Console.WriteLine($"Valor da Bonificação: {s.CalcularBonificacao}");

Gerente g = new Gerente("Gerente", 1000);
Console.WriteLine($"Valor da Bonificação: {g.CalcularBonificacao}");

Diretor d = new Diretor("Diretor", 1000);
Console.WriteLine($"Valor da Bonificação: {d.CalcularBonificacao}");

// =======================================================================================

GerenciadorBonificacao boni = new GerenciadorBonificacao();
boni.TotalizarBonificacao(funcionario);
boni.TotalizarBonificacao(secretario);
boni.TotalizarBonificacao(gerente);
boni.TotalizarBonificacao(diretor);

double bonificacaototal = boni.TotalBonificacao;
Console.WriteLine($"Total de bonificações: {bonificacaototal}");

// =======================================================================================

