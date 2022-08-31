using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PYP_Atribute_Pratice.Attributes
{
    public class ValidEmail:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {

            try
            {
                validationContext.ObjectType
                    .GetProperty(validationContext.MemberName)
                    .GetValue(value, null);

            }
            catch (Exception)
            {

                throw;
            }
            return null;
            
        }


    }
}
