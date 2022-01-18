namespace MS_Learning_Paths.AddingLogic
{
    internal class Iterating
    {
        /*
        Iterate through a code block using for statement in C#
        FizzBuzz rules:

        Output values from 1 to 100, one number per line.
        When the current value is divisible by 3, print the term Fizz next to the number.
        When the current value is divisible by 5, print the term Buzz next to the number.
        When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
          */

        int[] nums = new int[100];
        int count = 1;

        public void SetValRange() {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = count;
                count++;
            }
        }

        public void TestFizzBuzz()
        {
            foreach (int digit in nums)
            {
                if ((digit % 3 == 0) && (digit % 5 == 0))
                {
                    Console.WriteLine($"{digit} - FizzBuzz");
                }
                else if (digit % 3 == 0)
                {
                    Console.WriteLine($"{digit} - Fizz");
                }
                else if (digit % 5 == 0)
                {
                    Console.WriteLine($"{digit} - Buzz");
                }
                else Console.WriteLine(digit);
            }
        }

    }
}
