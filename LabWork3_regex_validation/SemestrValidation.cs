using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OOP_4SEM_3
{
    public class SemestrValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int sem = (int)value;
            if (value == null || !(sem == 1 || sem == 2))
            {
                this.ErrorMessage = "недопустимое значение семестра";
                return false;
            }
            else
                return true;
        }
    }
}
