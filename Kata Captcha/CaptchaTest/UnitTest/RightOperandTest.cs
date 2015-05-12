using System;
using Kata_Captcha;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class RightOperandTest
    {
        public KataCaptcha captcha;

        [Test]
        public void RightOperand_ShouldBe1_WhenInputIs1Pattern1()
        {
            captcha = new KataCaptcha(1, 1, 1, 1);
            Assert.AreEqual("1", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBeONE_WhenInputIs1Pattern2()
        {
            captcha = new KataCaptcha(2, 1, 1, 1);
            Assert.AreEqual("ONE", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBe2_WhenInputIs2Pattern1()
        {
            captcha = new KataCaptcha(1, 1, 1, 2);
            Assert.AreEqual("2", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBeTWO_WhenInputIs2Pattern2()
        {
            captcha = new KataCaptcha(2, 1, 1, 2);
            Assert.AreEqual("TWO", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBe8_WhenInputIs8Pattern1()
        {
            captcha = new KataCaptcha(1, 1, 1, 8);
            Assert.AreEqual("8", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBeEIGHT_WhenInputIs8Pattern2()
        {
            captcha = new KataCaptcha(2, 1, 1, 8);
            Assert.AreEqual("EIGHT", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBe9_WhenInputIs9Pattern1()
        {
            captcha = new KataCaptcha(1, 1, 1, 9);
            Assert.AreEqual("9", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBeNINE_WhenInputIs9Pattern2()
        {
            captcha = new KataCaptcha(2, 1, 1, 9);
            Assert.AreEqual("NINE", captcha.GetRightOperand());
        }

        [Test]
        public void RightOperand_ShouldBeThrownInvalidRangeException_WhenInputRightOperandIs0()
        {
            captcha = new KataCaptcha(1, 1, 1, 0);
            Assert.Throws(typeof(InvalidRangeException), delegate { captcha.GetRightOperand(); });
        }
        [Test]
        public void RightOperand_ShouldBeThrownInvalidRangeException_WhenInputRightOperandIs10()
        {
            captcha = new KataCaptcha(1, 1, 1, 10);
            Assert.Throws(typeof(InvalidRangeException), delegate { captcha.GetRightOperand(); });
        }

    }
}
