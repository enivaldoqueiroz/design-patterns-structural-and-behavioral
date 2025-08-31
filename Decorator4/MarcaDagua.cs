namespace Decorator4;

public class MarcaDagua : FotoDecorator
{
    private readonly string _texto;

    public MarcaDagua(IFoto inner, string texto) : base(inner)
    {
        _texto = string.IsNullOrWhiteSpace(texto) ? "© Direitos reservados" : texto;
    }

    public override string Renderizar()
    {
        // 1) Renderiza a base
        var baseRender = base.Renderizar();

        // 2) Adiciona a “marca d’água” (aqui estamos só simulando texto)
        // Em um caso real, você desenharia o texto na imagem (ex.: System.Drawing ou ImageSharp)
        return $"{baseRender} + MarcaDagua(\"{_texto}\")";
    }
}