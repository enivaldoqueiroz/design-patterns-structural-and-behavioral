using Encapsulamento1;

try
{
    Conta conta1 = new Conta();
    conta1.Saldo = 100;

    Console.WriteLine($"O Saldo da conta é {conta1.Saldo}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
