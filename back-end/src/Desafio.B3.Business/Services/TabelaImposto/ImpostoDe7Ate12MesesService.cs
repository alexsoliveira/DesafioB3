namespace Desafio.B3.Business.Services.TabelaImposto
{
    public class ImpostoDe7Ate12MesesService : ImpostoService
    {
        public override double ObterImposto(int mes)
        {
            if (mes < 13)
                return 20.0;

            return new ImpostoDe13Ate24MesesService().ObterImposto(mes);                     
        }
    }
}
