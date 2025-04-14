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
        public static void ShowBallance(string userName, string userAccId, double userAccBalance, double userCreditRemaining)
        {
            userName = userName.ToUpper();
            Console.WriteLine("Hisob raqam: " + userAccId);
            Console.WriteLine("Foydalanuvchi Ism - Familiyasi: " + userName);
            Console.WriteLine("Balans: " + userAccBalance + " so‘m");
            if (userCreditRemaining <= 0) {
                Console.WriteLine("Kredit To'lovi qolmadi");
            }
            else
            {
                Console.WriteLine("Kredit qoldig'i: " + userCreditRemaining);
            }
        }
    }
}
