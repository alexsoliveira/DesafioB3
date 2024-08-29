namespace Desafio.B3.Business.Domain
{
    public class CDB
    {        
        public double ValorMonetario { get; private set; }
        public int Mes { get; private set; }

        public CDB(double valorMonetario, int mes)
        {
            ValorMonetario = valorMonetario;
            Mes = mes;

            Validar();
        }

        private void Validar()
        {
            CDBValidation.ApenasNumerosPositivos(ValorMonetario, nameof(ValorMonetario));

            CDBValidation.ApenasNumerosInteirosMaiorQueUm(Mes, nameof(Mes));
        }
    }
}
