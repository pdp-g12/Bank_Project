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
        public static void ShowBallance(int userAccId, int userAccBalance)
        {
            Console.WriteLine("Hisob raqam: " + userAccId);
            Console.WriteLine("Balans: " + userAccBalance + " so‘m");
        }
    }
}
