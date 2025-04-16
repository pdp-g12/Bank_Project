using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class UserMoneyTransfers
    {
        //D.Javohir tomonidan yozilgan kod
        public static void UserMoneyTransfer(string[] userNames, ref double[] userAccBanks, ref int userAccPref, ref string userFindAccInput, ref string userMoneyTransferAccInsurance)
        {
            double userMoneyTransferAcc = 0;
            for (int i = 0; i < userNames.Length; i++)
            {
                if (userNames[i] == userFindAccInput)
                {
                RetryMoneyTransfer:
                    Console.WriteLine("Shu foydalanuvchiga pul o'tkazmoqchimisiz? (ha/yo'q)");
                    userMoneyTransferAccInsurance = Console.ReadLine();
                    userMoneyTransferAccInsurance = userMoneyTransferAccInsurance.ToLower();
                    if (userMoneyTransferAccInsurance == "ha")
                    {
                    RetryMoneyTransferInput:
                        Console.WriteLine("O'tkazmoqchi bo'lgan miqdorni kiriting:");
                        userMoneyTransferAcc = Convert.ToDouble(Console.ReadLine());
                        if(userMoneyTransferAcc < 0)
                        {
                            Console.WriteLine("Pul miqdori musbat(+) bo'lishi kerak");
                            goto RetryMoneyTransferInput;
                        }
                        else
                        {
                            if (userMoneyTransferAcc > userAccBanks[userAccPref])
                            {
                                Console.WriteLine("Hisobingizda yetarli mablag' yo'q");
                                goto RetryMoneyTransferInput;
                            }
                            else if (userAccBanks[userAccPref] == 0)
                            {
                                Console.WriteLine($"Foydalanuvchi mablag'i: {userAccBanks[userAccPref]} so'm");
                                Console.WriteLine("Foydalanuvchi mablag'i yetarli emas");
                                Console.WriteLine("Pul o'tkazish bekor qilindi");
                                userMoneyTransferAccInsurance = "";
                                userFindAccInput = "";
                                return;
                            }
                                userAccBanks[userAccPref] -= userMoneyTransferAcc;
                            userAccBanks[i] += userMoneyTransferAcc;
                            Console.WriteLine("Pul o'tkazish muvaffaqiyatli amalga oshirildi");
                            userMoneyTransferAccInsurance = "";
                            userFindAccInput = "";
                            return;
                        }
                    }
                    else if (userMoneyTransferAccInsurance == "yo'q")
                    {
                        Console.WriteLine("Pul o'tkazish bekor qilindi");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Xato javob kiritdingiz, qaytadan urinib ko'ring");
                        goto RetryMoneyTransfer;
                    }
                }
            }
            Console.WriteLine("Ism yoki Familiya xato kiritildi, qaytadan urinib ko'ring");
            userMoneyTransferAccInsurance = "yoq";
            return;
        }
    }
}
