namespace Mediator1;

//Colleague
public abstract class User
{
    protected IFacebookGroupMediator _mediator;
    protected string _name;

    public User(IFacebookGroupMediator facebookGroupMediator, string name)
    {
        _mediator = facebookGroupMediator;
        _name = name;
    }

    public abstract void Receive(string msg);

    public abstract void Send(string msg);
}