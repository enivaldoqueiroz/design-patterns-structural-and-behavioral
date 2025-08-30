using Facade2;

ComparaPreco comparaPreco = new ComparaPreco();
Console.WriteLine("### Pesquisar Preços de Livros ###");
Console.WriteLine("Informe o ISBN do Livro");
string isbn = Console.ReadLine();

List<Livro> livros = comparaPreco.Comparar(isbn);

Console.WriteLine($"\n ---- Resultado da Pesquisa ----\n");
foreach (var livro in livros)
{
    Console.WriteLine($"ISBN : {livro.ISBN} - {livro.Titulo} - {livro.Preco} - {livro.Origem}\n");
}

Console.ReadKey();