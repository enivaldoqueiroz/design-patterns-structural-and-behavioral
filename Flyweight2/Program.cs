using Flyweight2;

var factory = new ImagemFactory();

for (int i = 0; i < 6 ; i++)
{
    var imagem = factory.GetImagem("minhaImagem.jpg");
    imagem.Exibir(GetRandomPosicao(), GetRandomPosicao(), GetRandomDimensao(), GetRandomDimensao());
}

Console.ReadKey();

static int GetRandomPosicao(){
    var random = new Random();
    return random.Next(0, 500);
}

static int GetRandomDimensao()
{
    var random = new Random();
    return random.Next(100, 500);
}