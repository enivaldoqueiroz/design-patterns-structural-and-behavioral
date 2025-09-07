namespace Strategy1;

// Context
public class CompressaoContext
{
    private ICompressao _compressao;
    
    public CompressaoContext(ICompressao compressao)
    {
        _compressao = compressao;
    }

    public void CriarArquivoCompactado(string arquivo)
    {
        _compressao.ComprimirArquivo(arquivo);
    }

    public void DefineStrategy(ICompressao compressao)
    {
        _compressao = compressao;
    }
}