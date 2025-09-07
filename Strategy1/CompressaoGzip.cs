namespace Strategy1;

public class CompressaoGzip : ICompressao
{
    public void ComprimirArquivo(string arquivo)
    {
        Console.WriteLine($"Arquivo {arquivo} comprimido em formato .gzip");
    }
}