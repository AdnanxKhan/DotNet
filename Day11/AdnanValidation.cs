using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day11
{
    public class AdnanValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) 
            {
                string message =value.ToString();
                if (message.Contains("Adnan")) 
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName + "Field must contain Adnan";
            return new ValidationResult(ErrorMessage);
        }
    }
}