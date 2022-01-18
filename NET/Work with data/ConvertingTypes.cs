namespace MS_Learning_Paths.Work_with_data_in_CSharp
{
    internal class ConvertingTypes
    {

        /*
        Challenge 1:

        Split up the data depending on its type and either concatenate or add the data accordingly.
        Iterate through each value in a string of values.

        Start with the following line of code:
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        Business Rules:
        Rule 1: If the value is alphanumeric, concatenate it to form a message
        Rule 2: If the value is numeric, add it to the total
        Rule 3: Make sure the result matches the following output:
        Message: ABCDEF
        Total: 68.3
       */

        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        string message = "";
        decimal total = 0m;
        decimal digit;

        public void SortStrings()
        {

            foreach (var value in values)
            {
                if (decimal.TryParse(value, out digit))
                {
                    total += digit;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}");
        }
    }

    internal class ConvertingTypes2
    {
        /*
         
        Challenge 2:

         Starting code:
        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // Your code here to set result1
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
        // Your code here to set result2
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
        // Your code here to set result3
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
         */


        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        public void DecToInt()
        {
            int result1 = value1 / (int)value2;
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
        }

        public void FloatToDec()
        {
            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
        }
        public void IntToFloat()
        {
            float result3 = value3 / (float)value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

    }
}
