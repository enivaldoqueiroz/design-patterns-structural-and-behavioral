namespace Observer1;

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string Produto { get; set; }
    private int Preco { get; set; }
    private string Disponibilidade { get; set; }
    public ConcreteSubject(string produto, int preco, string status)
    {
        Produto = produto;
        Preco = preco;
        Disponibilidade = status;
    }

    public string GetDisponibilidade()
    {
        return Disponibilidade;
    }
    public void SetDisponibilidade(string status)
    {
        this.Disponibilidade = status;
        Console.WriteLine("A disponibilidade mudou de 'Sem Estoque' para 'Disponível'.");
        NotificarObservers();
    }
    public void RegistrarObserver(IObserver observer)
    {
        Console.WriteLine("Observer Adicionado : " + ((ConcreteObserver)observer).Usuario);
        observers.Add(observer);
    }
    public void AdicionarObservers(IObserver observer)
    {
        observers.Add(observer);
    }
    public void RemoverObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotificarObservers()
    {
        Console.WriteLine($"O Produto :{Produto} no valor de R$ {Preco} agora esta disponível." + 
                          "\n### Notificando todos os Observers registrados ### ");

        Console.WriteLine();
            
        foreach (IObserver observer in observers)
        {
            observer.Atualiza(Disponibilidade);
        }
    }
}