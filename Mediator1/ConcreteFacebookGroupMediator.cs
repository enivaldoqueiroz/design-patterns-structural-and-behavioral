namespace Mediator1;

//ConcreteMediator
public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
{
    private List<User> usersList = new List<User>();


    public void RegisterUser(User user)
    {
        usersList.Add(user);
    }

    public void SendMessage(string message, User user)
    {
        foreach (User userItem in usersList)
        {
            // Mensagem não sera recebida por quem a estiver enviando
            if (userItem != user)
                userItem.Receive(message);
        }
    }
}