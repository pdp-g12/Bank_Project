using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class xusanov
    {
        public static void MakePaymet(int type, double sum)
        {
            switch (type)
            {
                case 1:

                    Console.WriteLine("kamunal to'lovlar");
                    Console.WriteLine("1. Issiq suv");
                    Console.WriteLine("2. Gaz");
                    Console.WriteLine("3. Elektr energiya");

                home:;
                again:;
                    int kamunal = Convert.ToInt32(Console.ReadLine());

                    if (kamunal <= 0 || kamunal > 3)
                    {
                        Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                        goto home;
                    }

                    if (sum > 20000)
                    {
                        if (kamunal == 1)
                        {
                            Console.WriteLine($"Issiq suv to'lovi: {sum}");
                        }
                        else if (kamunal == 2)
                        {
                            Console.WriteLine($"Gaz to'lovi: {sum}");
                        }
                        else if (kamunal == 3)
                        {
                            Console.WriteLine($"Elektr energiya to'lovi: {sum}");
                        }
                    }
                    else
                    { 
                        Console.WriteLine("Tolovni amalga oshirish uchun 20000 so'mdan koproq mablag' kiritng ");
                        goto again;
                    }
                    break;
            }
        }
    }
}
