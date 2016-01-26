using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.Models.Validation
{
    public class CEPAttribute : ValidationAttribute
    {
        private string _cep;
        public CEPAttribute(string cep)
            :base("Curto demais")
        {
            _cep = cep;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}
