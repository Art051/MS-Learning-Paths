using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Learning_Paths.Work_with_data_in_CSharp
{
    internal class ModifyStrings
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        /*Extract, replace, remove

    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

    string quantity = "";
    string output = "";

    // Your work here

    Console.WriteLine(quantity);
    Console.WriteLine(output);


    Desired output:
    Quantity: 5000
    Output: <h2>Widgets &reg;</h2><span>5000</span>

        Set the quantity variable to the value you extract from between the <span> and </span> tags.
        Set the output variable to the value of input, then remove the <div> and </div> tags.
        Replace the HTML character &trade; with &reg; in the output variable.

    */


        public void adjustString()
        {

            int indexOfFive = input.IndexOf('5');
            int lastIndexOfZero = input.LastIndexOf('0');

            /* 
            My attempt:
            // Extract the quantity
            quantity = input.Substring(indexOfFive, lastIndexOfZero - indexOfFive);

            // <div>
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");

            output = output.Remove(divStart, (divEnd - (divStart)) - 1);


            // </div>
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            output = output.Remove(divCloseStart, (divCloseEnd - (divCloseStart)) - 1);

            output = input.Replace("&trade;", "&reg;");

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");

            */

            //Model answer:

            const string spanTag = "<span>";

            // Extract the quantity
            int quantityStart = input.IndexOf(spanTag);
            int quantityEnd = input.IndexOf("</span>");
            quantityStart += spanTag.Length;
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            output = input.Replace("&trade;", "&reg;");

            // Remove the opening <div> tag
            int divStart = input.IndexOf("<div");
            int divEnd = input.IndexOf(">");
            int divLength = divEnd - divStart;
            divLength += 1;
            output = output.Remove(divStart, divLength);

            // Remove the closing <div> tag
            int divCloseStart = output.IndexOf("</div");
            int divCloseEnd = output.IndexOf(">", divCloseStart);
            int divCloseLength = divCloseEnd - divCloseStart;
            divCloseLength += 1;
            output = output.Remove(divCloseStart, divCloseLength);

            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Output: {output}");
        }
    }

}
