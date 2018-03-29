using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitefinityWidgetWizard
{
    public static class Extensions
    {
        public static string CapitalizeFirstCharacter(this string value)
        {
            if (value == null)
                return string.Empty;

            if (value.Length > 1)
                return char.ToUpper(value[0]) + value.Substring(1);

            return value.ToUpper();
        }
    }
}
