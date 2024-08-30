namespace Desafio.B3.Api.ViewModels
{
    public class ResultadoInvestimentoViewModel
    {
        public double Bruto { get; private set; }
        public double Liquido { get; private set; }

        public ResultadoInvestimentoViewModel(double bruto, double liquido)
        {
            Bruto = bruto;
            Liquido = liquido;
        }
    }
}
