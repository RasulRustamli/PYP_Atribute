using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PYP_Atribute_Pratice.Validator
{
    public class CustomValidation
    {
        public static bool MailCheck(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
        public static bool PasswordCheck(string password)
        {
            var regexx = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[A-Za-z\\d@$!%*?&]{8,}");
            Match match = regexx.Match(password);
            return match.Success;
        }
    }
}
