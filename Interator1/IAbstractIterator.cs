namespace Interator1;

//Iterator
public interface IAbstractIterator
{
    bool IsDone { get; }
    Cliente First();
    Cliente Next();
}