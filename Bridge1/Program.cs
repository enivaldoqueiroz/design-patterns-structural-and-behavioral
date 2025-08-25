using Bridge1;

Funcionario funcionario = new Funcionario()
{
    Id = 1,
    Nome = "Enivaldo",
    SalarioBase = 3000,
    Incentivo = 2000
};

CalculaSalario calculaSalario = new CalculaSalario(new GeraXML());
calculaSalario.ProcessaSalarioFuncionario(funcionario);

funcionario.Incentivo = 1200;

calculaSalario = new CalculaSalario(new GeraJson());
calculaSalario.ProcessaSalarioFuncionario(funcionario);