using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Program
{
    class password
    {

        public static bool CheckPassword(string pasw, string pasw1)
        {


            if (pasw == pasw1)
            {


                Console.WriteLine("kiritgan paerol tog'ri");

                return true;
            }

            else
            {


                Console.WriteLine("kiritgan paerol tog'ri");

                return false;

            }


        }
    }
}
