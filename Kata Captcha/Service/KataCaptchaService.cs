using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kata_Captcha;
using Kata_Captcha.Helper;

namespace Service
{
    public class KataCaptchaService
    {
        private IRandom random;
        public KataCaptcha GetCaptcha()
        {
            return new KataCaptcha(random.RandomPattern(), random.RandomOperand(), random.RandomOperator(), random.RandomOperand());
        }
        public void SetRandomCaptcha(IRandom random)
        {
            this.random = random;
        }
    }
}
