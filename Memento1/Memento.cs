namespace Memento1;

//Memento - Representa o estado armazenado(Armazena o estado do objeto originator)
//Só temos Get não teremos como alterar os dados
public class Memento : ICarataker, IOriginator
{
    private int primeiroNumero;
    private int segundoNumero;

    public Memento(int numero1, int numero2)
    {   
        primeiroNumero = numero1;
        segundoNumero = numero2;
    }
    public int GetPrimeiroNumero()
    {
        return primeiroNumero;
    }

    public int GetSegundoNumero()
    {
        return segundoNumero;
    }
}