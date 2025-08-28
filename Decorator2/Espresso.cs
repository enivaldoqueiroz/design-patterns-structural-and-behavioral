namespace Decorator2
{
    public class Espresso : ICafe
    {
        public string Descricao()
        {
            return "Café expresso";
        }

        public decimal Preco()
        {
            return 5.00M;
        }
    }
}
