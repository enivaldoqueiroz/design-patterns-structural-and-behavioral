namespace Memento1;

//Define a interface para a implementação do Originator
public interface ICalculadora
{
    //CreateMomento
    ICarataker BackupUltimoCalculo();
    
    //SetMemento
    void RestoreUltimoCalculo(ICarataker memento);
    
    //Serviços do Originator
    int GetCalculoResultado();
    void SetPrimeiroNumero(int numero1);
    void SetSegundoNumero(int numero1);
    void GetSegundoNumero(int numero2);
}