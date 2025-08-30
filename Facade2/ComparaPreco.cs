using Facade2.Subsistemas;

namespace Facade2
{
    public class ComparaPreco
    {
        public List<Livro> Comparar(string isbn)
        {
            ServicoACliente clientA = new ServicoACliente();
            Livro livroA = clientA.PesquisaLivro(isbn);

            ServicoBCliente clientB = new ServicoBCliente();
            Livro livroB = clientB.PesquisaLivro(isbn);

            List<Livro> livros = new List<Livro>();
            livros.Add(livroA);
            livros.Add(livroB);

            livros.Sort(delegate (Livro b1, Livro b2)
            {
                return b1.Preco.CompareTo(b2.Preco);
            });

            return livros;
        }
    }
}
