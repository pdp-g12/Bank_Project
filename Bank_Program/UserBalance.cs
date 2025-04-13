using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    //Javlonbek kodlari
    class UserBalance
    {
        public static void ShowBallance(string userAccId, double userAccBalance, double userCreditRemaining)
        {
            Console.WriteLine("Hisob raqam: " + userAccId);
            Console.WriteLine("Balans: " + userAccBalance + " so‘m");
            Console.WriteLine("Kredit qoldig'i: " + userCreditRemaining);
        }
    }
}
