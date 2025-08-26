namespace Bridge3
{
    // Implementações concretas
    public class TV : IDispositivo
    {
        public void Ligar() => Console.WriteLine("TV ligada");
        public void Desligar() => Console.WriteLine("TV desligada");
        public void AjustarVolume(int valor) => Console.WriteLine($"Volume da TV ajustado para {valor}");
    }
}
