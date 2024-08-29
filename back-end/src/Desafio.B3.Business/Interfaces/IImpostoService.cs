namespace Desafio.B3.Business.Interfaces
{
    public interface IImpostoService
    {
        double ObterImposto(int mes);
        double ObterCalcula(double valorMonetario, double valorBruto, double imposto);
    }
}
