namespace Decorator2
{
    public class LeiteDecorator : OptionalDecorator
    {
        public LeiteDecorator(ICafe cafe) : base(cafe)
        {
            _optional = " mais porção de leite";
            _preco = 2.00M;
        }
    }
}
