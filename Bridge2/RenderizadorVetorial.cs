namespace Bridge2
{

    // Implementação concreta B
    public class RenderizadorVetorial : IRenderizador
    {
        public void DesenharCirculo(int raio)
        {
            Console.WriteLine($"Desenhando CÍRCULO com linhas vetoriais, raio = {raio}");
        }
    }
}
