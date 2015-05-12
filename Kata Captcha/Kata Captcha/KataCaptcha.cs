using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Captcha
{
    public class KataCaptcha
    {
        private int pattern;
        private int leftOperand;
        private int operation;
        private int rightOperand;

        private const int operandValuePlus = 1;
        private const int operandValueMutiple = 2;
        private const int operandValueMinus = 3;

        private const String plusOperand = "+";
        private const String minusOperand = "-";
        private const String multipleOperand = "*";

        private const int patternTextNumber = 1;
        private const int patternNumberText = 2;

        String[] TextNumberList = new String[] { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };


        public KataCaptcha(int pattern, int leftOperand, int operation, int rightOperand)
        {
            this.pattern = pattern;
            this.leftOperand = leftOperand;
            this.operation = operation;
            this.rightOperand = rightOperand;
        }


        public String GetLeftOperand()
        {
            ValidateOperandRange(leftOperand);
            String OperandText = "";
            if (pattern == patternTextNumber)
            {
                OperandText = TextNumberList[leftOperand - 1];
            }
            else if (pattern == patternNumberText)
            {
                OperandText = leftOperand.ToString();
            }
            return OperandText;
        }


        public String GetRightOperand()
        {
            ValidateOperandRange(rightOperand);
            String OperandText = "";
            if (pattern == patternTextNumber)
            {
                OperandText = this.rightOperand.ToString(); ;
            }
            else if (pattern == patternNumberText)
            {
                OperandText = TextNumberList[rightOperand - 1];
            }
            return OperandText;
        }

        public String GetOperator()
        {
            String operatorString = String.Empty;
            switch (this.operation)
            {
                case operandValuePlus: operatorString = plusOperand; break;
                case operandValueMutiple: operatorString = multipleOperand; break;
                case operandValueMinus: operatorString = minusOperand; break;
            }
            return operatorString;
        }

        private void ValidateOperandRange(int inputOperand)
        {
            if (inputOperand < 1 || inputOperand > 9) throw new InvalidRangeException();
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", GetLeftOperand(), GetOperator(), GetRightOperand());
        }

    }
}
