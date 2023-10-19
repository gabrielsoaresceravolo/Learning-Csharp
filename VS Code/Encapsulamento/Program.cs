// função Main();
using EncapsulamentoConta;

Conta c1 = new Conta();
//c1.numero = 10; é inacessível devido ao private
c1.SetNumero(10);
Console.WriteLine("Número da conta: " + c1.GetNumero());
//Padrão de encapsulamento de C#/Microfost
//alterar valor - set
c1.Titular = "Ana";
//busca do valor - get
Console.WriteLine("Nome do titular da conta: " + c1.Titular);
c1.Depositar(1000);
Console.WriteLine($"Saldo atual {c1.Saldo:C}");

