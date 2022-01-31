using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class FeverChecker
    {
        public static string Check(int inputTemp)
        {
            if(inputTemp >= 38)
            {
                return "You have a fever";
            }

            return "You don't have a fever";
        }
    }
}
