namespace Proxy3;

// Proxy (substituto da imagem real)
public class ImagemProxy : IImagem
{
    private readonly string _arquivo;
    private ImagemReal _imagemReal;

    public ImagemProxy(string arquivo)
    {
        _arquivo = arquivo;
    }

    public void Exibir()
    {
        // Carrega a imagem real apenas quando necessário
        if (_imagemReal == null)
        {
            _imagemReal = new ImagemReal(_arquivo);
        }
        _imagemReal.Exibir();
    }
}