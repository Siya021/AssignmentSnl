using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class NumberToWords
    {
        public NumberToWords()
        {
        }

        public static String[] Ones = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public static String[] Teens = { 
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        public static String[] Tens = {
            "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };
        
       
        public static string ConvertToWords(int number)
        {
            if (number == 0)
            {
                return "zero";
            }
            string words = "";
 
            if ((number / 1000) > 0)
            {
                words += ConvertToWords(number / 1000) + " thousand ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertToWords(number / 100) + " hundred ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }
                if (number < 10)
                {
                    words += Ones[number];
                }
                else if (number < 20)
                {
                    words += Teens[number - 10];
                }
                else
                {
                    words += Tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + Ones[number % 10];
                    }
                }
            }
            return words.Trim();    
        }

    }
}
