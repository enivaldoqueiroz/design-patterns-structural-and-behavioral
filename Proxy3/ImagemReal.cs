namespace Proxy3;

// Objeto real (pesado)
public class ImagemReal : IImagem
{
    private readonly string _arquivo;

    public ImagemReal(string arquivo)
    {
        _arquivo = arquivo;
        CarregarDoDisco(); // operação custosa
    }

    private void CarregarDoDisco()
    {
        Console.WriteLine($"Carregando imagem do disco: {_arquivo}");
    }

    public void Exibir()
    {
        Console.WriteLine($"Exibindo imagem: {_arquivo}");
    }
}