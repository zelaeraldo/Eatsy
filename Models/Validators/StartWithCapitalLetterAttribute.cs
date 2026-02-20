using System.ComponentModel.DataAnnotations;

namespace Eatsy1.Validators
{
    public class StartWithCapitalLetterAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue && !string.IsNullOrEmpty(stringValue))
            {
                if (char.IsUpper(stringValue[0]))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Fusha duhet të fillojë me shkronjë të madhe.");
                }
            }
            return new ValidationResult("Fusha është e pavlefshme.");
        }
    }
}