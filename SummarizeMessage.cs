using System;
using System.Text;

namespace SummarizeMessage
{
    class SummarizeMessage
    {
        static void Main(string[] args)
        {
            string msg = "A long message string that need to be summarized.";
            int maxLen = 20;

            Console.WriteLine("Original Message  : "+msg);
            Console.WriteLine("Summarized Message: "+SummarizeString(msg, maxLen) +
                "..."+", up to "+maxLen+" characters.");
        }

        // summarizes a message up to the max number of characters with a complete word
        // and no trailing space
        public static string SummarizeString(string str, int max)
        {
            str = str.Trim();
            int total = 0;
            var result = new StringBuilder();

            if (str.Length <= max)
                return str;

            var arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {   // current + next one
                int space = (0 == i) ? 0 : 1;

                if ((total + arr[i].Length + space) > max)
                    return result.ToString();

                if (0 != i)
                    result.Append(' ');

                result.Append(arr[i]);
                total += arr[i].Length + space;
            }
            return result.ToString();
        }

    }
}

//////////////////////////////////////////////////////////////
//
// Sample run:
//
// Original Message  : A long message string that need to be summarized.
// Summarized Message: A long message..., up to 20 characters.