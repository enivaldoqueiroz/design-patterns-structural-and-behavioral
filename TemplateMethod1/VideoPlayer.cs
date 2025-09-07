namespace TemplateMethod1;

// Classe Abstrata
public abstract class VideoPlayer
{
    // Template Method
    public void ExecutarVideo()
    {
        CarregarArquivo();
        DecodeVideoFormato();
        InciarExecucao();
    }
    
    // Procedimento Padrão
    public void CarregarArquivo()
    {
        Console.WriteLine("Arquivo de vídeo carregando...\n");
    }
    
    // Procedimento que será sobrescrito
    public abstract void DecodeVideoFormato();
    
    // Procedimento Padrão
    public void InciarExecucao()
    {
        Console.WriteLine("O video iniciou a execução...\n");
    }
}