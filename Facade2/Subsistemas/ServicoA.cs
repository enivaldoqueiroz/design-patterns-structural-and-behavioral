namespace Facade2.Subsistemas
{
    public class ServicoA
    {
        public static Livro GetLivro(string isbn)
        {
            var livro = new Livro
            {
                ISBN = isbn,
                Titulo = "Código Limpo",
                Preco = 76.20M,
                Autor = "",
                Origem = "Amazon.com"
            };

            return livro;
        }
    }
}
