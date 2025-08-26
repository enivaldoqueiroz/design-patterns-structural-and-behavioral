namespace Bridge2
{
    // Implementação concreta A
    public class RenderizadorRaster : IRenderizador
    {
        public void DesenharCirculo(int raio)
        {
            Console.WriteLine($"Desenhando CÍRCULO com pixels, raio = {raio}");
        }
    }
}
