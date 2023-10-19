// Função-Método Main()

using InterfaceAutenticavel;

// Não é possivel instaciar uma interface
// IAutenticavel ia = new IAutenticavel();

// ============================================

// Diretor
Diretor d = new Diretor(123);
IAutenticavel ia = d;
Console.WriteLine(ia.Autentica(123));

// Cliente
Cliente c = new Cliente(100);
ia = c;
Console.WriteLine(ia.Autentica(123));