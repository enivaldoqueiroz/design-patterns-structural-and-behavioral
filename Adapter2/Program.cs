using Adapter2;

var graficoSemAdapter = new MeuGeradorGrafico();
graficoSemAdapter.Titulo = "Gerador de Graficos Sem Adapter";
IGrafico graficoAdapter = new GraficoAdapter();
graficoAdapter.Titulo = "Gerador de Graficos Com Adapter";

List<string> xvalores = new List<string>();
xvalores.Add("Seg");
xvalores.Add("Ter");

List<int> yvalores = new List<int>();
yvalores.Add(10);
yvalores.Add(20);

graficoSemAdapter.GerarGrafico(graficoSemAdapter.Titulo, xvalores, yvalores);
Console.WriteLine("*****************************************");
graficoAdapter.GerarGrafico(graficoSemAdapter.Titulo, xvalores, yvalores);
Console.ReadLine();