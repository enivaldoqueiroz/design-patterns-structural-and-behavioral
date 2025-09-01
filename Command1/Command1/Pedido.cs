namespace Command1;

//ConcreteCommand
public class Pedido : Commad
{
    private Chef Chef { get; set; }
    private string Acao { get; set; }

    public Pedido(Chef chef, string acao)
    {
        Chef = chef;
        Acao = acao;
    }

    public override void Execute()
    {
        if (Acao.Equals("Prato"))
            Chef.PreparandoPrato();
        else
            Chef.PreparandoSobremesa();     
    }
}