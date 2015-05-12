using System;
using Kata_Captcha.Helper;

namespace Kata_Captcha
{
    public class RandomCaptchaProperty : IRandom
    {
        private Random random;


        private const int minimumPatternValue = 1;
        private const int maximumPatternValue = 2;

        private const int minimumOperandValue = 1;
        private const int maximumOperandValue = 9;

        private const int minimumOperatorValue = 1;
        private const int maximumOperatorValue = 3;

        public RandomCaptchaProperty()
        {
            random = new Random();
        }

        public int RandomPattern()
        {
            return random.Next(minimumPatternValue, maximumPatternValue);
        }

        public int RandomOperand()
        {
            return random.Next(minimumOperandValue, maximumOperandValue);
        }

        public int RandomOperator()
        {
            return random.Next(minimumOperatorValue, maximumOperatorValue);
        }
    }
}
