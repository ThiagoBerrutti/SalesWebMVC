using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class AgeValidationAttribute : ValidationAttribute
    {
        public int _minimumAge;
        
        

        public AgeValidationAttribute(int minimumAge):base()
        {
            _minimumAge = minimumAge; 
        }

        public override bool IsValid(object value)
        {
            if (DateTime.TryParse(value.ToString(), out DateTime date)){
                return date.AddYears(_minimumAge) < DateTime.Now;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.InvariantCulture, ErrorMessage, name, _minimumAge);
        }
    }
}

