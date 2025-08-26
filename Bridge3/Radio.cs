namespace Bridge3
{
    public class Radio : IDispositivo
    {
        public void Ligar() => Console.WriteLine("Rádio ligado");
        public void Desligar() => Console.WriteLine("Rádio desligado");
        public void AjustarVolume(int valor) => Console.WriteLine($"Volume do Rádio ajustado para {valor}");
    }
}
