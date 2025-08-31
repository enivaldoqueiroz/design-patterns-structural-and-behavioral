namespace Proxy2;

public class ProxyInternet : Internet
{
    private Internet internet = new RealInternet();
    private static readonly List<string> sitesPermitidos = new List<string>()
    {
        "pt.wikipedia.org",
        "abc.wikipedia.org",
        "def.net",
    };
    
    public override void Conexao(string host)
    {
        if (!sitesPermitidos.Contains(host.ToLower()))
            throw new Exception("### Acesso negado ###");
        
        internet.Conexao(host);
    }
}