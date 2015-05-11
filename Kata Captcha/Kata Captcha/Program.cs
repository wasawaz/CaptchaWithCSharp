using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Captcha
{
    class Program
    {
        static void Main(string[] args)
        {

            var captcha = new KatCaptcha(1, 1 ,1 ,1);

           Console.WriteLine( captcha.ToString());

            Console.ReadKey();
        }
    }

    public class KatCaptcha
    {
        public int Pattern { get; set; }
        public int LeftOperand { get; set; }
        public int RightOperand { get; set; }
        public int Operator { get; set; }

        public KatCaptcha(int pattern, int leftOperand, int oprt, int rightOperand)
        {
            Pattern = pattern;
            LeftOperand = leftOperand;
            RightOperand = rightOperand;
            Operator = oprt;
        }

        public override string ToString()
        {
            var text = "";
            if (Pattern == 1)
            {
                text = NumberToWords(LeftOperand);
            }
            else if (Pattern == 2)
            {
                text = NumberToWords(RightOperand);
            }

            return text;
        }

        public static string NumbertoOperator(int Operator)
        {
            string opd = string.Empty;
            switch (Operator)
            {
                case 1:
                    opd = "+";
                    break;
                case 2:
                    opd = "*";
                    break;
                case 3:
                    opd = "-";
                    break;
                default:
                    opd = "/"; break;

            }
            return opd;
        }


        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }


    }

}
