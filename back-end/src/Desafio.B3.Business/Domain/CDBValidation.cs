using Desafio.B3.Business.Exceptions;

namespace Desafio.B3.Business.Domain
{
    public static class CdbValidation
    {
        public static void ApenasNumerosPositivos(double target, string fieldName)
        {            
            if (target < 0.0)
                throw new EntityValidationException(
                    $"O campo {fieldName}, só aceita números inteiros ou decimais (0.0) positivos.");                    
        }

        public static void ApenasNumerosInteirosMaiorQueUm(int target, string fieldName)
        {
            if (target < 2)
                throw new EntityValidationException(
                    $"O campo {fieldName}, só aceita números inteiros maior que o número 1 (Um).");                    
        }
    }
}
