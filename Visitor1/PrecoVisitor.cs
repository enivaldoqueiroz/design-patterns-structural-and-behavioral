namespace Visitor1;

public class PrecoVisitor : IVisitor
{
    private const int CARRO_DESCONTO = 12;
    
    public void Accept(Carro carro)
    {
        decimal precoCarroAposDesconto = carro.Preco - ((carro.Preco)* CARRO_DESCONTO);

        Console.WriteLine($"{carro.Modelo} {carro.Nome} {precoCarroAposDesconto}");
    }
}