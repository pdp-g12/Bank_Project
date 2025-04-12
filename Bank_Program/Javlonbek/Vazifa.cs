using System;

public class BankAccount
{

    public BankAccount(string raqam, float boshlangichBalans)
    {
        hisobRaqam = raqam;
        balans = boshlangichBalans;
    }

    public void PulToldirish(float summa)
    {
        balans += summa;
        Console.WriteLine(summa + " so‘m toldirildi.");
    }

    public void PulYechish(float summa)
    {
        if (summa <= balans)
        {
            balans -= summa;
            Console.WriteLine(summa + " so‘m yechildi.");
        }
        else
        {
            Console.WriteLine("Hisobda yetarli mablag‘ yo‘q.");
        }
    }

    public void BalansniKorish()
    {
        Console.WriteLine("Hisob raqam: " + hisobRaqam);
        Console.WriteLine("Balans: " + balans + " so‘m");
    }
}
class Program
{
    static void Main()
    {
        BankAccount foydalanuvchi = new BankAccount("123456789", 100000);

        foydalanuvchi.BalansniKorish();
        foydalanuvchi.PulToldirish(50000);
        foydalanuvchi.PulYechish(30000);
        foydalanuvchi.BalansniKorish();
    }
}

