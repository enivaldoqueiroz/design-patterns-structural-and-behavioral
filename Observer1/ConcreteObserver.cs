namespace Observer1;

public class ConcreteObserver : IObserver
{
    public string Usuario { get; set; }
    
    public ConcreteObserver(string usuario, ISubject subject)
    {
        Usuario = usuario;
        subject.RegistrarObserver(this);
    }
    
    public void Atualiza(string disponibilidade)
    {
        Console.WriteLine($"Olá {Usuario}, o produto que você deseja agora esta {disponibilidade} em nosso site");
    }
}