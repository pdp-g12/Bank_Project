// See https://aka.ms/new-console-template for more information
using Bank_Program;

//D.Javohir yozgan kodi
int userPref = 0;
int userServicePref = 0;
string userInputPassword = "";
string[] userNames = { "aliyev javlonbek", "toshpulatov sherzod", "doniyorov javohir", "husanov", "bill gates", "elon mask", "mark sukerberck", "pavel durov" };
string[] userPasswords = { "4565", "1234", "7890", "0000", "1111", "2222", "3333", "4444" };
string[] userAccIds = { "a3434hgd", "b1234hgd", "777777", "d0000hgd", "e1111hgd", "f2222hgd", "g3333hgd", "h4444hgd" };
double[] userAccBanks = { 2000000, 3000000, 99999999999, 99, 6000000, 999999, 9888888, 909999090 };
double[] userCreditRemainings = { 500000, 600000, 700000, 9999999, 900000, 999999, 9999999, 9999999 };
string userInputName = "";

Console.WriteLine("Bankomat dasturiga xush kelibsiz");
RetryVerification:
Console.WriteLine("Akkauntga kirish uchun foydalanuvchi Ism - Familiyasini kiriting:");
userInputName = Console.ReadLine();
userInputName = userInputName.ToLower();
Console.WriteLine("Foydalanuvchi paroli:");
userInputPassword = Console.ReadLine();
userInputPassword = userInputPassword.ToLower();

if (UserVerificationClass.UserVerification(userNames[2], userInputName, userPasswords[2], userInputPassword))
{
    Console.WriteLine("Ism va Parol to'g'ri, akkauntga kirish muvaffaqiyatli amalga oshirildi....");
RetryServicePref:
    Console.WriteLine("1.Bankomat - Kommunal To'lovlar, Kredit, Mobil aloqa, Naqd pul olish");
    Console.WriteLine("2.Foydalanuvchi hisobi haqidagi ma'lumotlar");
    userServicePref = Convert.ToInt32(Console.ReadLine());
    if (userServicePref != 1 && userServicePref != 2)
    {
        Console.WriteLine("Xato son kiritdingiz, qaytadan urinib ko'ring");
        Console.WriteLine("1 yoki 2 ni bosing");
        goto RetryServicePref;
    }
    else if (userServicePref == 1)
    {
        UserBankOptions.userBankMain(userPref, ref userAccBanks[2], ref userCreditRemainings[2]);
        goto RetryServicePref;
    }
    else if (userServicePref == 2)
    {
        UserBalance.ShowBallance(userAccIds[2], userAccBanks[2], userCreditRemainings[2]);
        goto RetryServicePref;
    }
}
else
{
    Console.WriteLine("Parol yoki Ism - Familiya noto'g'ri, Iltamos yana urinib ko'ring");
    goto RetryVerification;
}