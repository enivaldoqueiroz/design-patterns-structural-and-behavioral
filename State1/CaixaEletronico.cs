namespace State1;

public class CaixaEletronico : ICaixaEletronicoState
{
    public ICaixaEletronicoState caixaEletronicoState {  get; set; }
    
    public CaixaEletronico()
    {
        caixaEletronicoState = new CartaoNaoInseridoState();
    }

    public void InserirCartao()
    {
        caixaEletronicoState.InserirCartao(); // Cartão foi inserido, estado mudou para CartaoInseridoState

        if (caixaEletronicoState is CartaoNaoInseridoState)
        {
            caixaEletronicoState = new CartaoInseridoState();
            Console.WriteLine($"O estado interno do caixa eletronico foi alterado para : " +
                              $"{caixaEletronicoState.GetType().Name}");
        }
    }

    public void EjetarCartao()
    {
        caixaEletronicoState.EjetarCartao(); // Cartão foi ejetado, estado mudou para CartaoNaoInserdiState
        if (caixaEletronicoState is CartaoInseridoState)
        {
            caixaEletronicoState = new CartaoInseridoState();
            Console.WriteLine($"O estado interno do caixa eletronico foi alterado para: " +
                              $"{caixaEletronicoState.GetType().Name}");
        }
    }

    public void InformarSenha()
    {
        caixaEletronicoState.InformarSenha();
    }

    public void SacarDinheiro()
    {
        caixaEletronicoState.SacarDinheiro();
    }
}