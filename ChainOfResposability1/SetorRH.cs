namespace ChainOfResposability1
{
    public class SetorRH : Autorizador
    {
        private int ALCADA_DIAS = 30;

        public override void AutorizarLicenca(string nome, int dias)
        {
            if (dias <= ALCADA_DIAS)
                AprovarLicenca(nome, dias);
            else
                Console.WriteLine($"\n Não foi possível autorizar a licença de {dias} dias para : {nome}.\n *** Comuinque a Diretoria ***");
        }

        public override void AprovarLicenca(string nome, int dias)
        {
            Console.WriteLine($"O Setor de RH aprovou {dias} dias de licença remunerada para : {nome}\n");
        }
    }
}
