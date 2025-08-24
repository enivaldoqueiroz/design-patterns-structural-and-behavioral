using ClasseAbstrata1;

Quadrado quadrado = new Quadrado();

Console.WriteLine(quadrado.Descricao());

Console.WriteLine("Informe o valor da lado do quadrado em metros");
quadrado.Lado = Convert.ToDouble(Console.ReadLine());
quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine($"A área do quadrado é: {quadrado.Area} m2");
Console.WriteLine($"A perímetro do quadrado é: {quadrado.Perimetro} m");

Console.ReadLine();