using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeManagement.Validation
{
        class RequiredFiedValidationRule : ValidationRule
        {
            public RequiredFiedValidationRule()
            {

            }
            public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {
                if (value.ToString().Length > 0)
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, "* Required");
                }
            }

    }
    }

