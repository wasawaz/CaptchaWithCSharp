using System;
using Kata_Captcha;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class LeftOperandTest
    {
        public KataCaptcha captcha;
        [Test]
        public void LeftOperandShouldBe_ONE_WhenInput1Pattern1()
        {
            captcha = new KataCaptcha(1, 1, 1, 1);
            Assert.AreEqual("ONE", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_ONE_WhenInput1Pattern2()
        {
            captcha = new KataCaptcha(2, 1, 1, 1);
            Assert.AreEqual("1", captcha.GetLeftOperand());
        }


        [Test]
        public void LeftOperandShouldBe_TWO_WhenInput2Pattern1()
        {
            captcha = new KataCaptcha(1, 2, 1, 1);
            Assert.AreEqual("TWO", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_2_WhenInput2Pattern2()
        {
            captcha = new KataCaptcha(2, 2, 1, 1);
            Assert.AreEqual("2", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_THREE_WhenInput3Pattern1()
        {
            captcha = new KataCaptcha(1, 3, 1, 1);
            Assert.AreEqual("THREE", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_3_WhenInput3Pattern2()
        {
            captcha = new KataCaptcha(2, 3, 1, 1);
            Assert.AreEqual("3", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_FOUR_WhenInput4Pattern1()
        {
            captcha = new KataCaptcha(1, 4, 1, 1);
            Assert.AreEqual("FOUR", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_4_WhenInput4Pattern2()
        {
            captcha = new KataCaptcha(2, 4, 1, 1);
            Assert.AreEqual("4", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_EIGHT_WhenInput8Pattern1()
        {
            captcha = new KataCaptcha(1, 8, 1, 1);
            Assert.AreEqual("EIGHT", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_8_WhenInput8Pattern2()
        {
            captcha = new KataCaptcha(2, 8, 1, 1);
            Assert.AreEqual("8", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_NINE_WhenInput9Pattern1()
        {
            captcha = new KataCaptcha(1, 9, 1, 1);
            Assert.AreEqual("NINE", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperandShouldBe_9_WhenInput9Pattern2()
        {
            captcha = new KataCaptcha(2, 9, 1, 1);
            Assert.AreEqual("9", captcha.GetLeftOperand());
        }

        [Test]
        public void LeftOperand_ShouldBeThrownInvalidRangeException_WhenInputLeftOperandIs0()
        {
            captcha = new KataCaptcha(1, 0, 1, 1);
            Assert.Throws(typeof(InvalidRangeException), delegate { captcha.GetLeftOperand(); });
        }
        [Test]
        public void LeftOperand_ShouldBeThrownInvalidRangeException_WhenInputLeftOperandIs10()
        {
            captcha = new KataCaptcha(1, 10, 1, 1);
            Assert.Throws(typeof(InvalidRangeException), delegate { captcha.GetLeftOperand(); });
        }

    }
}
