using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class password
    {

        public static void CheckPassword()
        {
            string pasw = "1234";
      
           
            Console.WriteLine("paroldi kriting");
             names:
            string pasw1 = Console.ReadLine();
      
            if (pasw == pasw1)
            {

                Console.WriteLine("kiritgan parol tog'ri");

            }

            else
            {
                Console.WriteLine("kiritgan parol hato");
                Console.WriteLine("boshqattan urunib koring ");

                goto names;
            }
           
            Console.WriteLine("1.kamunal tolovlar ");
            Console.WriteLine("  ");
            Console.WriteLine("2.balans ");
            Console.WriteLine("  ");
            Console.WriteLine("3.naqt pul yechish ");
            Console.WriteLine("  ");
            Console.WriteLine("4.paynet ");
            Console.WriteLine("  ");
         

        }
    }
}
