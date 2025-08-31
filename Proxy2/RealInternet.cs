namespace Proxy2;

public class RealInternet : Internet
{
    public override void Conexao(string host)
    {
        Console.WriteLine($"Conectando-se com o servidor : {host}\n");
    }
}