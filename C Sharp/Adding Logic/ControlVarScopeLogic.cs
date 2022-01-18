using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Learning_Paths.AddingLogic
{
    internal class ControlVarScopeLogic
    {
        //Control variable scope and logic using code blocks in C#

        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        public void Find42()
        {
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                {
                    found = true;
                }
            }
            if (found) Console.WriteLine("Set contains 42");
            
            Console.WriteLine($"Total: {total}");
        }
    }
}
