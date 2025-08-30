namespace Flyweight3
{
    // Flyweight (estado compartilhado)
    public class CaractereFlyweight
    {
        public char Simbolo { get; }
        public string Fonte { get; }
        public int Tamanho { get; }

        public CaractereFlyweight(char simbolo, string fonte, int tamanho)
        {
            Simbolo = simbolo;
            Fonte = fonte;
            Tamanho = tamanho;
        }

        // Estado extrínseco (posição e cor) é fornecido de fora
        public void Desenhar(int posX, int posY, string cor)
        {
            Console.WriteLine($"'{Simbolo}' [{Fonte}, {Tamanho}px] na posição ({posX},{posY}) cor {cor}");
        }
    }
}
