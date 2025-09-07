namespace State1;

public class CartaoNaoInseridoState : ICaixaEletronicoState
{
    public void InserirCartao()
    {
        Console.WriteLine("Cartão Inserido com sucesso");
    }

    public void EjetarCartao()
    {
        Console.WriteLine("Não é possível ejectar o cartão. O cartão não foi inserido");
    }

    public void InformarSenha()
    {
        Console.WriteLine("Não é possível informar a senha. Insira o cartão");
    }

    public void SacarDinheiro()
    {
        Console.WriteLine("Não é possível realizar o seque. Insira o cartão");
    }
}