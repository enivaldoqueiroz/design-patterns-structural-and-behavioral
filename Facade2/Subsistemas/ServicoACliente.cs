namespace Facade2.Subsistemas
{
    public class ServicoACliente
    {
        public Livro PesquisaLivro(string isbn)
        {
            //definir instancia HttpClient
            //definir endereço base
            //definir formato de resposta JSON
            //montar o request GET
            //tratar a reposta no formato JSON
            return ServicoA.GetLivro(isbn);
        }
    }
}
