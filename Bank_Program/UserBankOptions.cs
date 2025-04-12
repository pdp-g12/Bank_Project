using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class UserBankOptions
    {
        public static void userBankMain(int userBankPref, ref double userAccBank, ref double userCreditRemaining)
        {
            Console.WriteLine("Bank xizmatlari: ");
            Console.WriteLine("1. Kamunal to'lovlar");
            Console.WriteLine("2. Kredit to'lovlari");
            Console.WriteLine("Birinchi xizmat uchun 1 - ni bosing");
            Console.WriteLine("Ikkinchi xizmat uchun 2 - ni bosing");
            userBankPref = Convert.ToInt32(Console.ReadLine());
            int userInsurrancePref = 0;

            switch (userBankPref)
            {
                case 1:

                Home:
                    Console.WriteLine("Kamunal To'lovlar: ");
                    Console.WriteLine("1.Issiq suv");
                    Console.WriteLine("2.Gaz");
                    Console.WriteLine("3.Elektr energiya");
                    Console.WriteLine("Birinchi xizmat uchun 1 - ni bosing");
                    Console.WriteLine("Ikkinchi xizmat uchun 2 - ni bosing");
                    Console.WriteLine("Uchinchi xizmat uchun 3 - ni bosing");
                    int userCommunalPref = Convert.ToInt32(Console.ReadLine());

                    if (userCommunalPref <= 0 || userCommunalPref > 3)
                    {
                        Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                        goto Home;
                    }

                    if (userAccBank >= 350000)
                    {
                        if (userCommunalPref == 1)
                        {
                            Console.WriteLine("Issiq suv to'lovi: 35000so'm");
                            Console.WriteLine();
                            Console.WriteLine("To'lash:  ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            userInsurrancePref = Convert.ToInt32(Console.ReadLine());
                            if (userInsurrancePref == 1)
                            {
                                Console.WriteLine("To'lov qabul qilindi, to'lov summasi: 35000 so'm");
                                userAccBank -= 35000;
                            }
                            else if (userInsurrancePref != 1 && userInsurrancePref != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto Home;
                            }
                            else if (userInsurrancePref == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling");
                            RepeatPay:
                            Console.WriteLine("Yana kamunal tolov qilasizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int retryCommunalPay = Convert.ToInt32(Console.ReadLine());

                            if (retryCommunalPay == 1) goto Home;
                            else if (retryCommunalPay != 1 && retryCommunalPay != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto RepeatPay;
                            }
                            else if (retryCommunalPay == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling"); return;

                        }
                        else if (userCommunalPref == 2)
                        {
                            Console.WriteLine("Gaz to'lovi: 45000so'm");
                            Console.WriteLine();
                            Console.WriteLine("To'lash:  ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            userInsurrancePref = Convert.ToInt32(Console.ReadLine());
                            if (userInsurrancePref == 1)
                            {
                                Console.WriteLine("To'lov qabul qilindi, to'lov summasi: 35000 so'm");
                                userAccBank -= 45000;
                            }
                            else if (userInsurrancePref != 1 && userInsurrancePref != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto Home;
                            }
                            else if (userInsurrancePref == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling");
                            RepeatPay:
                            Console.WriteLine("Yana kamunal tolov qilasizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int retryCommunalPay = Convert.ToInt32(Console.ReadLine());

                            if (retryCommunalPay == 1) goto Home;
                            else if (retryCommunalPay != 1 && retryCommunalPay != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto RepeatPay;
                            }
                            else if (retryCommunalPay == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling"); return;
                        }
                        else if (userCommunalPref == 3)
                        {
                            Console.WriteLine("Elektr to'k to'lovi: 55000so'm");
                            Console.WriteLine();
                            Console.WriteLine("To'lash:  ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            userInsurrancePref = Convert.ToInt32(Console.ReadLine());
                            if (userInsurrancePref == 1)
                            {
                                Console.WriteLine("To'lov qabul qilindi, to'lov summasi: 55000 so'm");
                                userAccBank -= 55000;
                            }
                            else if (userInsurrancePref != 1 && userInsurrancePref != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto Home;
                            }
                            else if (userInsurrancePref == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling");
                            RepeatPay:
                            Console.WriteLine("Yana kamunal tolov qilasizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int retryCommunalPay = Convert.ToInt32(Console.ReadLine());

                            if (retryCommunalPay == 1) goto Home;
                            else if (retryCommunalPay != 1 && retryCommunalPay != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto RepeatPay;
                            }
                            else if (retryCommunalPay == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling"); return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tolovni amalga oshirish uchun eng kamida 350000 so'mdan koproq mablag' kerak");
                        return;
                    }
                    break;
                case 2:
                CreditHome:
                    Console.WriteLine("1. Kredit qoldig'i");
                    int userCreditPref = Convert.ToInt32(Console.ReadLine());
                    int userCreditPayAmount = 0;

                    if (userCreditPref == 1)
                    {
                        Console.WriteLine($"kredit qoldig'i: {userCreditRemaining}");
                    RetryCreditPay:
                        Console.WriteLine("1. Kredit to'lash ");
                        
                        int userPayCreditPref = Convert.ToInt32(Console.ReadLine());

                        if (userPayCreditPref == 1)
                        {
                            Console.WriteLine("Kredit to'lovi miqdori kiriting: ");
                            userCreditPayAmount = Convert.ToInt32(Console.ReadLine());
                            if (userAccBank < 50000) Console.WriteLine("Foydalanuvchi mablag'i kamida 500000 so'mni tashkil qilishi kerak");
                            else
                            {
                                userCreditRemaining -= userCreditPayAmount;
                                Console.WriteLine($"Kredit to'lovi qabul qilindi, to'lov summasi: {userCreditPayAmount} so'm");
                                return;
                            }
                        }
                        else Console.WriteLine("Xato son kiritdingiz"); goto RetryCreditPay;
                    }
                    else Console.WriteLine("Xato son kiritdingiz"); goto CreditHome;

            }
        }
    }
}
