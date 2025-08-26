namespace Composite3
{
    // Folha (Leaf)
    public class Arquivo : INodo
    {
        private readonly string _nome;

        public Arquivo(string nome)
        {
            _nome = nome;
        }

        public void Exibir(int nivel = 0)
        {
            Console.WriteLine(new string('-', nivel) + " " + _nome);
        }
    }
}
