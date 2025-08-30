namespace Proxy1
{
    //RealSubject - Objeto que queremos usar de forma mais eficiente usando a classe poxy
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoDeLeituraGravacao()
        {
            //Define operação a ser realizada na pasta Real
            Console.WriteLine("### Operação de Leitura e Escrita na pasta compartilhada ###");
        }
    }
}
