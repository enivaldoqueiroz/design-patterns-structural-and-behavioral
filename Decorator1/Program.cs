using Decorator1;

IPizza pizzaMussarela = new Pizza("Mussarela");
Console.WriteLine(pizzaMussarela.Opcionais());
Console.WriteLine($"Preço R$ {pizzaMussarela.Preco()}");

Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadLine();
Console.WriteLine("--------- Aplicando o Decorator ----------");

IPizza massaEspecial = new MassaEspecialDecorator(pizzaMussarela);
IPizza baconDecorator = new BaconDecorator(massaEspecial);
IPizza bordaDecorator = new BordaReacheadaDecorator(baconDecorator);

Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine($"Preço Total R$ : {bordaDecorator.Preco()} \n");

Console.ReadLine();