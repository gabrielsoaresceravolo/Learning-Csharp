// função Main()

using ConstrutorConta;

Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(1);
c2.MostrarAtributos();

Conta c3 = new Conta(2, "Bia", 100);
c3.MostrarAtributos();