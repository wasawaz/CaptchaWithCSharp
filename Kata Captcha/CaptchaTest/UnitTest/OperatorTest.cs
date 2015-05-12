using System;
using Kata_Captcha;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class OperatorTest
    {
        KataCaptcha captcha;
        [Test]
        public void OperatorString_ShouldBePlus_WhenOperatorIs1()
        {
            captcha = new KataCaptcha(1, 1, 1, 1);
            Assert.AreEqual("+", captcha.GetOperator());
        }

        [Test]
        public void OperatorString_ShouldBeMultiple_WhenOperatorIs2()
        {
            captcha = new KataCaptcha(1, 1, 2, 1);
            Assert.AreEqual("*", captcha.GetOperator());
        }

        [Test]
        public void OperatorString_ShouldBeMinus_WhenOperatorIs3()
        {
            captcha = new KataCaptcha(1, 1, 3, 1);
            Assert.AreEqual("-", captcha.GetOperator());
        }
    }
}
