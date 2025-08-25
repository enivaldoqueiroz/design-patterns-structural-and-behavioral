namespace Bridge1
{
    public class GeraJson : IGerarArquivo
    {
        public void GeraAquivo(Funcionario funcionario)
        {
            //Logica para gerar os dados no formato JSON
            Console.WriteLine($"Dados do funcionário {funcionario.Nome} gerados no formato JSON");
        }
    }
}
