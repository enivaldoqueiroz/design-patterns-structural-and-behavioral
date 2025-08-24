namespace Adapter2
{
    public class GraficoAdapter : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }

        public void GerarGrafico(string Titulo, List<string> x, List<int> y)
        {
            SuperGeradorGrafico grafico = new SuperGeradorGrafico();
            grafico.DesenharGrafico(Titulo, x, y);
        }
    }
}
