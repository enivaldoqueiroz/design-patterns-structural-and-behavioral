namespace Mediator1;

//Mediator
public interface IFacebookGroupMediator
{
    void RegisterUser(User user);
    void SendMessage(string message, User user);
}