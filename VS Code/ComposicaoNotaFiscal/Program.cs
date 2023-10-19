// função Main()

using ComposicaoNotaFiscal;

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(15);
List<ItemNotaFiscal> vetorItens = new List<ItemNotaFiscal>();
vetorItens.Add(it1);
vetorItens.Add(it2);
//Esta forma de instâncxia representa o objeto nota fiscal, ter
// um vetor de Itens já preenchido/populado
NotaFiscal nf1 = new NotaFiscal(1, "15/06/2023", vetorItens);
foreach (ItemNotaFiscal v in nf1.VetItens)
    v.MostrarItem();

NotaFiscal nf2 = new NotaFiscal(2, "15/06/2023");
nf2.VetItens.Add(it1);
nf2.VetItens.Add(it2);
Console.WriteLine("\nApresentação dos itens da Nota Fiscal");

    
