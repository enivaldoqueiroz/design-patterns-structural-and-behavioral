namespace Strategy1;

public class CompressaoZip : ICompressao
{
    public void ComprimirArquivo(string arquivo)
    {
        Console.WriteLine($"Arquivo {arquivo} comprimido em formato .zip");
    }
}