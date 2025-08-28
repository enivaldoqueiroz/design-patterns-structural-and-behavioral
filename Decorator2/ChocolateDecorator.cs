namespace Decorator2
{
    public class ChocolateDecorator : OptionalDecorator
    {
        public ChocolateDecorator(ICafe cafe) : base(cafe)
        {
            _optional = "  mais generosa porção de chocolate";
            _preco = 3.00M;
        }
    }
}
