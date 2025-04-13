using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    //Xusanov(Shu class kodlarini yozgan odam) & D.Javohir(kodni ozgina tartibga kiritgan odam) & Sherzod va Husanov tomonidan kredit ideasi qilgan odamlar
    class UserBankOptions
    {
        public static void userBankMain(int userBankPref, ref double userAccBank, ref double userCreditRemaining)
        {
            Console.WriteLine("Bank xizmatlari: ");
            Console.WriteLine("1. Kamunal to'lovlar");
            Console.WriteLine("2. Kredit to'lovlari");
            Console.WriteLine("3. Naqd pul olish");
            Console.WriteLine("4. Mobil aloqa to'lovi");
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
                            else if (userInsurrancePref == 2)
                            {
                                Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling");
                                return;
                            }
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
                case 3:
                RetryCashPay:
                    Console.WriteLine("1.Naqd pul olish");

                    int userCashPref = Convert.ToInt32(Console.ReadLine());
                    if (userCashPref <= 0 || userCashPref > 1)
                    {
                        Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring:");
                        goto RetryCashPay;
                    }
                    if (userAccBank < 20000)
                    {
                        Console.WriteLine("Foydalanuvchi mablag'i kamida 20000 so'mni tashkil qilishi kerak");
                        return;
                    }
                    if (userCashPref == 1)
                    {
                        Console.WriteLine("Naqd pul olish summasini kiriting:");
                        double userCash = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Naqd pul olindi: {userCash}");
                        userAccBank -= userCash;
                        goto Home;
                    }
                    break;
                case 4:
                MobileCallHome:
                    Console.WriteLine("1.Mobil aloqa to'lovi");
                    int mobileCall = Convert.ToInt32(Console.ReadLine());
                    if (mobileCall <= 0 || mobileCall > 1)
                    {
                        Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                        goto MobileCallHome;
                    }
                    if (mobileCall == 1)
                    {
                    UserMobileCallPrefHome:
                        Console.WriteLine("1. Ucell");
                        Console.WriteLine("2. Beeline");
                        Console.WriteLine("3. Uzmobile");
                        int mobileType = Convert.ToInt32(Console.ReadLine());
                        if (mobileType <= 0 || mobileType > 3)
                        {
                            Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                            goto UserMobileCallPrefHome;
                        }
                        else if (mobileType == 1)
                        {
                        UcellHome:
                            Console.WriteLine("Ucell uchun to'lov summasini kiriting: ");
                            double userUcellMobileInputPrice = Convert.ToDouble(Console.ReadLine());
                            if (userAccBank >= 2000)
                            {
                                Console.WriteLine($"Ucell uchun to'lov qabul qilindi: {userUcellMobileInputPrice}");
                                userAccBank -= userUcellMobileInputPrice;
                            }
                            else if (userAccBank < 2000)
                            {
                                Console.WriteLine("Foydalanuvchi mablag'i kamida 2000 so'mni tashkil qilishi kerak");
                            }
                            else if (userUcellMobileInputPrice < 2000)
                            {
                                Console.WriteLine("Yetarli Mablag' kiritnagansiz!");
                                Console.WriteLine("Kamida 2000so'm mablag' to'lanishi kerak");
                                goto UcellHome;
                            }
                        }
                        else if (mobileType == 2)
                        {
                        BeelineHome:
                            Console.WriteLine("Beeline uchun to'lov summasini kiriting: ");
                            double userBeelineMobileInputPrice = Convert.ToDouble(Console.ReadLine());
                            if (userAccBank >= 2000)
                            {
                                Console.WriteLine($"Beeline uchun to'lov qabul qilindi: {userBeelineMobileInputPrice}");
                                userAccBank -= userBeelineMobileInputPrice;
                            }
                            else if (userAccBank < 2000)
                            {
                                Console.WriteLine("Foydalanuvchi mablag'i kamida 2000 so'mni tashkil qilishi kerak");
                            }
                            else if (userBeelineMobileInputPrice < 2000)
                            {
                                Console.WriteLine("Yetarli Mablag' kiritnagansiz!");
                                Console.WriteLine("Kamida 2000so'm mablag' to'lanishi kerak");
                                goto BeelineHome;
                            }
                        }
                        else if (mobileType == 3)
                        {
                        UzMobileHome:
                            Console.WriteLine("Uzmobile uchun to'lov summasini kiriting: ");
                            double userUzMobileMobileInputPrice = Convert.ToDouble(Console.ReadLine());
                            if (userAccBank >= 2000)
                            {
                                Console.WriteLine($"UzMobile uchun to'lov qabul qilindi: {userUzMobileMobileInputPrice}");
                                userAccBank -= userUzMobileMobileInputPrice;
                            }
                            else if (userAccBank < 2000)
                            {
                                Console.WriteLine("Foydalanuvchi mablag'i kamida 2000 so'mni tashkil qilishi kerak");
                            }
                            else if (userUzMobileMobileInputPrice < 2000)
                            {
                                Console.WriteLine("Yetarli Mablag' kiritnagansiz!");
                                Console.WriteLine("Kamida 2000so'm mablag' to'lanishi kerak");
                                goto UzMobileHome;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Xato son kiritdingiz ");
                            goto MobileCallHome;
                        }
                    }
                    break;
            }
        }
    }
}
