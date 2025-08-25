namespace Bridge1
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGerarArquivo gerarArquivo) : base(gerarArquivo)
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;
            Console.WriteLine($"Valor do salário para o funcionario {funcionario.Nome} : R$ {funcionario.SalarioTotal}");

            _gerarArquivo.GeraAquivo(funcionario);
        }
    }
}
