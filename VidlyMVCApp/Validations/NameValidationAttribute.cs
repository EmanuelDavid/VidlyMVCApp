using System.ComponentModel.DataAnnotations;

namespace VidlyMVCApp.Validations
{
    public class NameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) // Checking for Empty Value
            {
                return new ValidationResult("Please Provide Name");
            }

            if (value.ToString().Contains("@"))
            {
                return new ValidationResult(" Name should Not contain @");
            }
            return ValidationResult.Success;
        }
    }
}