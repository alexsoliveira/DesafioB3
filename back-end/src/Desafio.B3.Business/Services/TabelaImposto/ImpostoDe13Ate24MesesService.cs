namespace Desafio.B3.Business.Services.TabelaImposto
{
    public class ImpostoDe13Ate24MesesService : ImpostoService
    {
        public override double ObterImposto(int mes)
        {
            if (mes < 25)
                return 17.5;

            return new ImpostoAcimaDe24MesesService().ObterImposto(mes);                
        }
    }
}
