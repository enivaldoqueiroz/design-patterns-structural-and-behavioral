using Decorator2;

var bebidas = new List<ICafe>
{
    new ChocolateDecorator(new Filtrado()), // Café filtrado com chocolate
    new LeiteDecorator(new Filtrado()),  // Café filtrado com leite
    new ChocolateDecorator(new LeiteDecorator(new Espresso())), // Café espresso com leite e chocolate
};

var filtradoChocolate = bebidas.First();
Console.WriteLine(filtradoChocolate.Descricao());
Console.WriteLine($"{filtradoChocolate.Preco()}\n");

var filtradoLeite = bebidas.Skip(1).First();
Console.WriteLine(filtradoLeite.Descricao());
Console.WriteLine($"{filtradoLeite.Preco()}\n");

var expressoLeiteChocolate = bebidas.Skip(2).First();
Console.WriteLine(expressoLeiteChocolate.Descricao());
Console.WriteLine($"{expressoLeiteChocolate.Preco()}\n");

Console.ReadKey();