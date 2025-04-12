using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                
                home:;
                    Console.WriteLine("kamunal to'lovlar");
                    Console.WriteLine("1. Issiq suv");
                    Console.WriteLine("2. Gaz");
                    Console.WriteLine("3. Elektr energiya");

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
                            Console.WriteLine();
                        home1:;
                            Console.WriteLine("Yana kamunal tolov qilsizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int yanatolav = Convert.ToInt32(Console.ReadLine());

                            if (yanatolav == 1) goto home;
                            else if(yanatolav != 1 && yanatolav != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto home1;
                            }
                            else if (yanatolav == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling"); return;
                           
                        }
                        else if (kamunal == 2)
                        {
                            Console.WriteLine($"Gaz to'lovi: {sum}");
                        home1:;
                            Console.WriteLine("Yana kamunal tolov qilsizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int yanatolav = Convert.ToInt32(Console.ReadLine());

                            if (yanatolav == 1) goto home;
                            else if (yanatolav != 1 && yanatolav != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto home1;
                            }
                            else if (yanatolav == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling"); return;
                        }
                        else if (kamunal == 3)
                        {
                            Console.WriteLine($"Elektr energiya to'lovi: {sum}");
                        home1:;
                            Console.WriteLine("Yana kamunal tolov qilsizmi? ");
                            Console.WriteLine("1. Ha ");
                            Console.WriteLine("2. Yoq ");
                            int yanatolav = Convert.ToInt32(Console.ReadLine());

                            if (yanatolav == 1) goto home;
                            else if (yanatolav != 1 && yanatolav != 2)
                            {
                                Console.WriteLine("Xato kiritdingiz, qaytadan urinib ko'ring");
                                goto home1;
                            }
                            else if (yanatolav == 2) Console.WriteLine("To'lovingiz uchun rahmat salomat bo'ling");return ;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tolovni amalga oshirish uchun 20000 so'mdan koproq mablag' kiritng ");
                        goto home;
                    }
                    break;
                case 2:
                kredit:;
                    Console.WriteLine("1. Kredit qoldig'i");
                    int menyu = Convert.ToInt32(Console.ReadLine());

                    if (menyu == 1)
                    {                        
                        int KreditQoldiq = 5890000;
                        Console.WriteLine($"kredit qoldig'i: {KreditQoldiq}");
                    home2:;
                        Console.WriteLine("1. Kredit to'lash ");

                        int KreditMen = Convert.ToInt32(Console.ReadLine());

                        if(KreditMen == 1)
                        {
                            if (sum < 500000 ) Console.WriteLine("tolov summasi 700000 so'mdan kam");
                            else Console.WriteLine($"To'lov qabul qilindi, tolov sum: {sum}"); return;
                        }
                        else Console.WriteLine("Xato son kiritdingiz "); goto home2;
                    }
                    else Console.WriteLine("Xato son kiritdingiz "); goto kredit;
                    
            }
        }
    }
}
