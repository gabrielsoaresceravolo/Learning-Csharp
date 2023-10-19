// função/método Main()

using ConstrutorFuncionario;

Funcionario f1 = new Funcionario();
f1.Mostrar();
Console.WriteLine("Quantidade de instâncias: " + Funcionario.ContadorInstancias);

Funcionario f2 = new Funcionario(2, "Ana");
f2.Mostrar();
Console.WriteLine("Quantidade de instâncias: " + Funcionario.ContadorInstancias);

Funcionario f3 = new Funcionario(3, "Bia", 300);
f3.Mostrar();
Console.WriteLine("Quantidade de instâncias: " + Funcionario.ContadorInstancias);
