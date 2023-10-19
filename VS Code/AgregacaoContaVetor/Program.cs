// método Main()

using AgregacaoContaVetor;

Cliente cli1 = new Cliente("Ana Beatriz", "Rua Terezina, 75", 11, "PP");
Cliente cli2 = new Cliente("Ana Clara", "Rua Manaus, 10", 12, "PP");

Conta c1 = new Conta();
c1.Numero = 190;
c1.Saldo = 1000;
c1.VetTitular = new List<Cliente>();
c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);

Console.WriteLine("\nListagem de clientes usando o for");
c1.ListarClientesFor();

Console.WriteLine("\nListagem de clientes usando o foreach");
c1.ListarClientesForeach();







