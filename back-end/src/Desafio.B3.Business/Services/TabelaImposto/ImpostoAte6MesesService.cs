namespace Desafio.B3.Business.Services.TabelaImposto
{
    public class ImpostoAte6MesesService : ImpostoService
    {
        public override double ObterImposto(int mes)
        {
            if(mes < 7)
                return 22.5;

            return new ImpostoDe7Ate12MesesService().ObterImposto(mes);            
        }
    }
}
