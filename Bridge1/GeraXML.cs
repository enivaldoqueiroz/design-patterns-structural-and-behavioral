namespace Bridge1
{
    public class GeraXML : IGerarArquivo
    {
        public void GeraAquivo(Funcionario funcionario)
        {
            //Logica para gerar os dados no formato XML
            Console.WriteLine($"Dados do funcionário {funcionario.Nome} gerados no formato XML");
        }
    }
}
