namespace Command1;

public class Garcom
{
    private Pedido _pedido;

    public Garcom(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Excutar()
    {
        _pedido.Execute();
    }
}