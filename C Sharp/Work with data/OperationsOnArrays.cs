using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Learning_Paths.Work_with_data_in_CSharp
{
    internal class OperationsOnArrays
    {
    }
    internal class WordReversal
    {
        //Challenge 1:

        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] panStringArr;

        string[] finalSentence;

        int panStrinRevPos;
        int finalSentPos = 0;

        //asssigning each word in original array to the opposite position in final sentence array
        public void RevStrToArr()
        {
            panStringArr = pangram.Split(' ');
            finalSentence = new string[panStringArr.Length];
            panStrinRevPos = panStringArr.Length - 1;
            for (int i = 0; i < panStringArr.Length; i++)
            {
                finalSentence[i] = panStringArr[panStrinRevPos];
                panStrinRevPos--;
            }
        }

        //splitting final sentence string[] into chars and then into string
        public void StrToCharArr()
        {
            for (int k = 0; k < panStringArr.Length; k++)
            {
                char[] finalSentToChars = finalSentence[k].ToCharArray();
                finalSentence[finalSentPos] = new string(finalSentToChars);
                finalSentPos++;

            }

            string finalSentenceString = string.Join(' ', finalSentence);
            Console.WriteLine(finalSentenceString);
        }


        ////////////////////////////////////////////////////////////////////

        //correct layout:
        /*
         string pangram = "The quick brown fox jumps over the lazy dog";

        string[] message = pangram.Split(' ');
        string[] newMessage = new string[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
            char[] letters = message[i].ToCharArray();
            Array.Reverse(letters);
            newMessage[i] = new string(letters);
        }

        string result = String.Join(" ", newMessage);
        Console.WriteLine(result);
        */


    }

    internal class ParseStrings
    {

        /* Second challenge:
         
         Using the code below as a starting point, you'll need to parse Order IDs out of a string containing a sequence of incoming orders (the orderStream).
         Then, you'll print each Order ID that starts with the letter "B".
        
        AttributeTargets output : 
            B123
            B177
            B179
        */

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        public void identifyIDs()
        {
            string[] orderStreamArr = orderStream.Split(',');

            foreach (string order in orderStreamArr)
            {
                if (order.StartsWith("B"))
                    Console.WriteLine(order);
            }
        }
    }

}
