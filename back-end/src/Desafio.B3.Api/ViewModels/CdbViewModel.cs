namespace Desafio.B3.Api.ViewModels
{
    public class CdbViewModel
    {
        public double ValorMonetario { get; set; }
        public int Mes { get; set; }

        public CdbViewModel(double valorMonetario, int mes)
        {
            ValorMonetario = valorMonetario;
            Mes = mes;            
        }
    }
}
