namespace Adapter2
{
    public class MeuGeradorGrafico : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }

        public void GerarGrafico(string titulo, List<string> x, List<int> y)
        {
            //logica para gerar o grafico
            Console.WriteLine($"{titulo}");
            Console.WriteLine("\n << MeuGeradorGrafico : Gerando Gráfico >>");
        }
    }
}
