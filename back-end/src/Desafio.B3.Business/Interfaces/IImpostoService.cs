namespace Desafio.B3.Business.Interfaces
{
    public interface IImpostoService
    {
        double ObterImposto(int mes);
        double ObterCalculo(double valorMonetario, double valorBruto, double imposto);
    }
}
