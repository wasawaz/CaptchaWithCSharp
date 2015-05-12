using System;
using Kata_Captcha;
using NUnit.Framework;


namespace CaptchaTest
{
    [TestFixture]
    public class CaptchaStringTest
    {
        KataCaptcha captcha;
        [Test]
        public void CaptchaString_ShouldBeONEPlus1_WhenLeftOperandIs1OperationIsPlusRightOperandIs1PatternIs1() {
             captcha = new KataCaptcha(1, 1, 1, 1);
             Assert.AreEqual("ONE + 1",captcha.ToString());
        }

        [Test]
        public void CaptchaString_ShouldBe1PlusONE_WhenLeftOperandIs1OperationIsPlusRightOperandIs1PatternIs2()
        {
            captcha = new KataCaptcha(2, 1, 1, 1);
            Assert.AreEqual("1 + ONE", captcha.ToString());
        }

        [Test]
        public void CaptchaString_ShouldBeTWOPlus1_WhenLeftOperandIs2OperationIsPlusRightOperandIs1PatternIs1()
        {
            captcha = new KataCaptcha(1, 2, 1, 1);
            Assert.AreEqual("TWO + 1", captcha.ToString());
        }

        [Test]
        public void CaptchaString_ShouldBe1PlusTWO_WhenLeftOperandIs2OperationIsPlusRightOperandIs1PatternIs2()
        {
            captcha = new KataCaptcha(2, 2, 1, 1);
            Assert.AreEqual("2 + ONE", captcha.ToString());
        }


    }
}
