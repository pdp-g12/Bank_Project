using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class userPassword
    {
        //Sherzod tomonidan yozilgan kod
        public static bool CheckPassword(string userPassword, string userInputPassword)
        {
            if (userInputPassword == userPassword) return true;
            else return false;
        }
    }
}
