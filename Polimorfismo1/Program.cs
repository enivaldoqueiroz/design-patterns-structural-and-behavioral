using Polimorfismo1;

var figuras = new List<Figura>
{
    new Circulo(),
    new Triangulo()
};

foreach (var figura in figuras)
{
    figura.Desenhar();
}

Console.ReadLine();