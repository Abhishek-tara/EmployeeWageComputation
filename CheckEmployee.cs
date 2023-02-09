using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CheckEmployee
    {
        public static void EmployeeCheck()
        {
            int IS_FULLTIME = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULLTIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            

        }


    }
}
