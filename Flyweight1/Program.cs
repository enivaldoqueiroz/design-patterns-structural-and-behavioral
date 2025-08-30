

using Flyweight1;

for (int i = 0; i < 5; i++)
{
    var personagem = (Soldado)PersonagemFactory.GetPersonagem("soldado");
    personagem.Poder = GetRandomPoderSoldado();
    personagem.Render();
}

Console.WriteLine("\n-------------------------------------------------");

for (int i = 0; i < 5; i++)
{
    var personagem = (Piloto)PersonagemFactory.GetPersonagem("piloto");
    personagem.Poder = GetRandomPoderPiloto();
    personagem.Render();
}

Console.ReadKey();

static int GetRandomPoderSoldado()
{
    Random rnd = new Random();
    return rnd.Next(10, 50);
}

static int GetRandomPoderPiloto()
{
    Random rnd = new Random();
    return rnd.Next(10, 50);
}