using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultBlazor.Wasm.Data
{
    public class TestAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var propertyTestedInfo = validationContext.ObjectType.GetProperty(""); //error will show up here. The validationContext is null after the control loses focus

            return ValidationResult.Success;
        }
    }
}
