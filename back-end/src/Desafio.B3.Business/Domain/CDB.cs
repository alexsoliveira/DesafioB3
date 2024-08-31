namespace Desafio.B3.Business.Domain
{
    public class Cdb
    {        
        public double ValorMonetario { get; private set; }
        public int Mes { get; private set; }

        public Cdb(double valorMonetario, int mes)
        {
            ValorMonetario = valorMonetario;
            Mes = mes;

            Validar();
        }

        private void Validar()
        {
            CdbValidation.ApenasNumerosPositivos(ValorMonetario, nameof(ValorMonetario));

            CdbValidation.ApenasNumerosInteirosMaiorQueUm(Mes, nameof(Mes));
        }
    }
}
