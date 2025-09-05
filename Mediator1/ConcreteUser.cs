namespace Mediator1;

//ConcreteColleague
public class ConcreteUser : User
{
    public ConcreteUser(IFacebookGroupMediator mediator, string name) 
        : base(mediator, name)
    { }

    public override void Receive(string msg)
    {
        Console.WriteLine($"{_name} : mensagem recebida <= {msg}");
    }

    public override void Send(string msg)
    {
        Console.WriteLine($"{_name}  : mensagem enviada => {msg}\n");
        _mediator.SendMessage(msg, this);
    }
}