namespace Composite3
{
    // Composto (Composite)
    public class Pasta : INodo
    {
        private readonly string _nome;
        private readonly List<INodo> _filhos = new();

        public Pasta(string nome)
        {
            _nome = nome;
        }

        public void Adicionar(INodo nodo)
        {
            _filhos.Add(nodo);
        }

        public void Exibir(int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + " [Pasta] " + _nome);
            foreach (var filho in _filhos)
            {
                filho.Exibir(nivel + 2);
            }
        }
    }
}
