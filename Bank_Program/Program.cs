// See https://aka.ms/new-console-template for more information
using Bank_Program;

int userPref = 0;
int userServicePref = 0;
string userAccId = "a3434hgd";
double userAccBank = 2000000;
double userCreditRemaining = 500000;
string userPassword = "4565";
string userInputPassword = "";
string userName = "aliyev javlonbek";
string userInputName = "";

Console.WriteLine("Bankomat dasturiga xush kelibsiz");
RetryVerification:
Console.WriteLine("Akkauntga kirish uchun foydalanuvchi Ism - Familiyasini kiriting:");
userInputName = Console.ReadLine();
userInputName = userInputName.ToLower();
Console.WriteLine("Foydalanuvchi paroli:");
userInputPassword = Console.ReadLine();
userInputPassword = userInputPassword.ToLower();

if (UserVerificationClass.UserVerification(userName, userInputName, userPassword, userInputPassword))
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
        UserBankOptions.userBankMain(userPref, ref userAccBank, ref userCreditRemaining);
        goto RetryServicePref;
    }
    else if (userServicePref == 2)
    {
        UserBalance.ShowBallance(userAccId, userAccBank, userCreditRemaining);
        goto RetryServicePref;
    }
}
else
{
    Console.WriteLine("Parol yoki Ism - Familiya noto'g'ri, Iltamos yana urinib ko'ring");
    goto RetryVerification;
}