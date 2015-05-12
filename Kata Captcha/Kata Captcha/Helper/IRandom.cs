using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Captcha.Helper
{
    public interface IRandom
    {
        int RandomPattern();
        int RandomOperand();
        int RandomOperator();
    }
}
