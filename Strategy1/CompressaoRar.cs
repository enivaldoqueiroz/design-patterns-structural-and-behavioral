namespace Strategy1;

public class CompressaoRar : ICompressao
{
    public void ComprimirArquivo(string arquivo)
    {
        Console.WriteLine($"Arquivo {arquivo} comprimido em formato .rar");
    }
}