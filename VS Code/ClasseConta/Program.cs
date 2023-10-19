using ClasseConta;
// função Main() implícita

//tipo nome_de_variável; - declação de variável
Conta c1;
//instância de objeto
c1 = new Conta();
c1.Mostrar();
c1.numero = 1;
c1.titular = "Ana";
c1.saldo = 100;
c1.Mostrar();
Console.Write("Informe o valor a sacar: ");
double saque = Convert.ToDouble(Console.ReadLine());
c1.Sacar(saque);
c1.Mostrar();

Conta c2 = new Conta();
Console.Write("Digite o número: ");
c2.numero = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o titular: ");
c2.titular = Console.ReadLine();
Console.Write("Digite o saldo: ");
c2.saldo = Convert.ToDouble(Console.ReadLine());
c2.Mostrar();
Console.Write("Informe o valor a depositar: ");
double deposito = Convert.ToDouble(Console.ReadLine());
c2.Depositar(deposito);
c2.Mostrar();
c1.Transferir(50, c2);
c1.Mostrar();
c2.Mostrar();