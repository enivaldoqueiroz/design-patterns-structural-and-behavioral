namespace Decorator4;

public class FotoDecorator : IFoto
{
    protected readonly IFoto _inner;

    protected FotoDecorator(IFoto inner)
    {
        _inner = inner;
    }

    // Por padrão, delega a chamada ao componente interno
    public virtual string Renderizar() => _inner.Renderizar();
}