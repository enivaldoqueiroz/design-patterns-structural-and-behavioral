
using Mediator1;

//
IFacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

User enivaldo = new ConcreteUser(facebookMediator, "Enivaldo");
User lana = new ConcreteUser(facebookMediator, "Lana");
User mila = new ConcreteUser(facebookMediator, "Mila");
User bernardo = new ConcreteUser(facebookMediator, "Bernardo");

facebookMediator.RegisterUser(enivaldo);
facebookMediator.RegisterUser(lana);
facebookMediator.RegisterUser(mila);
facebookMediator.RegisterUser(bernardo);

enivaldo.Send("Enivaldo esta aprendendo sobre Padrões de Projetos");

lana.Send("Quer saber como a Mila está");

enivaldo.Send("A Mila esta muito bem");

Console.Read();