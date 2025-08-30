namespace Facade2.Subsistemas
{
    public class ServicoBCliente
    {
        public Livro PesquisaLivro(string isbn)
        {
            //definir instancia HttpClient
            //definir endereço base
            //definir formato de resposta JSON
            //montar o request GET
            //tratar a reposta no formato JSON
            return ServicoB.GetLivro(isbn);
        }
    }
}
