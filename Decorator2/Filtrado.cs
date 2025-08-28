using Decorator2;

public class Filtrado : ICafe
{
    public string Descricao()
    {
        return "Café filtrado";
    }

    public decimal Preco()
    {
        return 4.00M;
    }
}