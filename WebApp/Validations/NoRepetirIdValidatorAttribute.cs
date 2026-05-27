using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using WebApp.Models;

namespace WebApp.Validations
{
    //Cada vez que se haga un validador personalizado se tiene que crear una clase
    //Al final debe de tener validatorattribute
    public class NoRepetirIdValidatorAttribute : ValidationAttribute
    {
        private IList<Proyector> _proyectores;
        public NoRepetirIdValidatorAttribute(IList<Proyector> proyectores) 
        { 
            _proyectores = proyectores;
        }

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return null;
            }
            return ValidationResult.Success;    
        }
    }
}
