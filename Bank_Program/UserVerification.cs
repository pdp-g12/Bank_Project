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
        public static bool UserVerification(string userName, string userInputName, string userPassword, string userInputPassword)
        {
            if (userName == userInputName)
            {
                if (userPassword == userInputPassword)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Parol noto'g'ri, Iltimos yana urinib ko'ring");
                    return false;
                }
            }
            else return false;
        }
    }
}
