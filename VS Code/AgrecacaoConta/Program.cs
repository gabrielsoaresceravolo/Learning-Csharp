// método Main()

using AgregacaoConta;

Cliente cli = new Cliente("Ana",
    "Rua Terezina, 75", 123, "PP");

Conta conta1 = new Conta();
conta1.Numero = 1;
conta1.Saldo = 100;
conta1.Titular = cli;
conta1.Titular.Mostrar();

Conta conta2 = new Conta();
conta2.Numero = 2;
conta2.Saldo = 200;
conta2.Titular = new Cliente();
conta2.Titular.Nome = "Bia";
conta2.Titular.Endereco = "Rua Ceará, 10";
conta2.Titular.Telefone = 124;
conta2.Titular.Cidade = "PP";
conta2.Titular.Mostrar();


