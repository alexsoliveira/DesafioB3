namespace Desafio.B3.Business.Services.TabelaImposto
{
    public class ImpostoAcimaDe24MesesService : ImpostoService
    {
        public override double ObterImposto(int mes)
        {
            if (mes > 24)
                return 15.0;

            return base.ObterImposto(mes);            
        }
    }
}
