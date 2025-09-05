namespace Interator1;

public class Iterator : IAbstractIterator
{
    private int current = 0;
    private int step = 1;
    private ConcreteCollection colletion;
    
    public Iterator(ConcreteCollection colletion)
    {
        this.colletion = colletion;
    }
    public bool IsDone
    {
        get { return current >= colletion.Count; }
    }

    // Retorna o primeiro item
    public Cliente First()
    {
        current = 0;
        return colletion.GetCliente(current);
    }

    public Cliente Next()
    {
        current += step;
        if (!IsDone)
            return colletion.GetCliente(current);

        return null;
    }
}