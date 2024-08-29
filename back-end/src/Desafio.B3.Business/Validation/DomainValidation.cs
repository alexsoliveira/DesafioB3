using Desafio.B3.Business.Exceptions;

namespace Desafio.B3.Business.Validation
{
    public class DomainValidation
    {
        public static void ApenasNumeros(string? target, string fieldName)
        {
            var isTrue = double.TryParse(target, out var result);

            if (!isTrue)
                throw new EntityValidationException(
                    $"O campo {fieldName}, só aceita números inteiros ou decimais (0.0) positivos.");
        }        

        public static void ApenasNumerosInteiros(string? target, string fieldName)
        {
            var isTrue = int.TryParse(target, out var result);

            if (!isTrue)
                throw new EntityValidationException(
                    $"O campo {fieldName}, só aceita números inteiros.");                    
        }        
    }
}
