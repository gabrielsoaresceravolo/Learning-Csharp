namespace AbstrataDepartamento
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public bool VerificarMaioridade()
        {
            return Idade >= 18;
        }
    }
}