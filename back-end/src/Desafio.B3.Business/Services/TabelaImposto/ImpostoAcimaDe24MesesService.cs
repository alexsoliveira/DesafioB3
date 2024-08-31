namespace Desafio.B3.Business.Services.TabelaImposto
{
    public class ImpostoAcimaDe24MesesService : ImpostoService
    {
        public override double ObterImposto(int mes)
        {
            return 15.0;                      
        }
    }
}
