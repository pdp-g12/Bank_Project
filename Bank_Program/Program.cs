// See https://aka.ms/new-console-template for more information
using Bank_Program;

int userPref = 0;
double userAccBank = 200000;
double userCreditRemaining = 500000;
string password = "4565";
string userInputPassword = "";

Console.WriteLine("Bankomat dasturiga xush kelibsiz");
Console.WriteLine("Akkauntga kirish uchun parolni kiriting:");
RetryPassword:
userInputPassword = Console.ReadLine();

if (userPassword.CheckPassword(password, userInputPassword))
{
    UserBankOptions.userBankMain(userPref, ref userAccBank, ref userCreditRemaining);
}
else
{
    Console.WriteLine("Parol noto'g'ri, Iltamos yana urinib ko'ring");
    goto RetryPassword;
}