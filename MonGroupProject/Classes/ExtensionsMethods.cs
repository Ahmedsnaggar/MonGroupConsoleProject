using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGroupProject.Classes
{
    internal static class ExtensionsMethods
    {
        /// <summary>
        /// Convert text to upper case
        /// </summary>
        /// <param name="text">string to convert</param>
        /// <returns>uppered case text</returns>
        public static string UpperCase(this string text)
        {
            return text.ToUpper();
        }
        public static int ConvertoNumber(this string str) 
        {
            int number;
            bool isnumber = int.TryParse(str, out number);
            if (isnumber == false)
                return 0;
            else
                return number;
        }
    }
}
