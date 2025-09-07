namespace Memento1;

//Originator
//Implementa ICalculadora e restaura o estado anterior

public class Calculadora : ICalculadora
{
    private int primeiroNumero;
    private int segundoNumero;
    
    // Corresponde ao Método CreateMemento()
    public ICarataker BackupUltimoCalculo()
    {
        // Cria um objeto Memento usado para restuarar os dois numeros
        return new Memento(primeiroNumero,  segundoNumero);
    }
    
    // Corresponde ao Método SetMemento()
    // Executa a lógica para restaurar o estado anterior
    public void RestoreUltimoCalculo(ICarataker memento)
    {
        primeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
        segundoNumero  = ((IOriginator)memento).GetSegundoNumero();
    }

    public int GetCalculoResultado()
    {
        // Retorna o resultado da soma dos dois numeros
        return primeiroNumero + segundoNumero;
    }

    public void SetPrimeiroNumero(int numero1)
    {
        primeiroNumero = numero1;
    }

    public void SetSegundoNumero(int numero1)
    {
        segundoNumero = numero1;
    }

    public void GetSegundoNumero(int numero2)
    {
        segundoNumero  = numero2;
    }
}