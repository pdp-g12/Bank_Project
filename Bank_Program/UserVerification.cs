using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class UserVerificationClass
    {
        //Sherzod tomonidan yozilgan kod
        public static bool UserVerification(string[] userNames, string userInputName, string[] userPasswords, string userInputPassword, ref int maxTryVerification, ref int userAccPref)
        {
            bool userVerification = false;
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userInputName == userNames[i] && userInputPassword == userPasswords[i])
                {
                    userVerification = true;
                    userAccPref = i;
                    break;
                }
            }
            if (userVerification)
            {
                return true;
            }
            else
            {
                maxTryVerification--;
                Console.WriteLine("Ism yoki parol xato, qaytadan urinib ko'ring");
                Console.WriteLine("Qolgan urinishlaringiz: " + maxTryVerification);
                return false;
            }
        }
    }
}
