namespace Facade2.Subsistemas
{
    public class ServicoB
    {
        public static Livro GetLivro(string isbn)
        {
            var livro = new Livro
            {
                ISBN = isbn,
                Titulo = "Código Limpo",
                Preco = 80.99M,
                Autor = "",
                Origem = "Livraria Cultura"
            };

            return livro;
        }
    }
}
