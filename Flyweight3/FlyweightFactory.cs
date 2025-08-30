namespace Flyweight3
{
    // Flyweight Factory
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CaractereFlyweight> _cache = new();

        public CaractereFlyweight GetCaractere(char simbolo, string fonte, int tamanho)
        {
            string chave = $"{simbolo}_{fonte}_{tamanho}";
            if (!_cache.ContainsKey(chave))
            {
                _cache[chave] = new CaractereFlyweight(simbolo, fonte, tamanho);
                Console.WriteLine($"[Novo] Criado Flyweight para '{simbolo}' ({fonte}, {tamanho}px)");
            }
            return _cache[chave];
        }
    }
}
