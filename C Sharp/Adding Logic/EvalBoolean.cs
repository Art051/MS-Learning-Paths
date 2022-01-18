using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Learning_Paths.AddingLogic
{
    internal class EvalBoolean
    {
        string permission = "Admin|Manager";
        int level = 55;

        public void EvaluateCondition()
        {
            if (permission.Equals("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin User");
                }

                else if (level <= 55)
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Equals("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }

                else if (level < 20)
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else if ((!permission.Equals("Admin")) && (!permission.Equals("Manager")))
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }

        }

    }
}
