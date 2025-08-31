namespace Decorator4;

//ConcreteComponent
public class Foto : IFoto
{
    public string Arquivo { get; }

    public Foto(string arquivo)
    {
        Arquivo = arquivo ?? throw new ArgumentNullException(nameof(arquivo));
    }

    public string Renderizar()
    {
        // Aqui você exibiria a imagem original (sem marca d’água)
        return $"[FOTO] {Arquivo}";
    }
}