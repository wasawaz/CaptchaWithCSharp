using System;
using Kata_Captcha;
using Kata_Captcha.Helper;
using NSubstitute;
using NUnit.Framework;
using Service;


namespace CaptchaTest.IntegrateTest
{
    [TestFixture]
    class KataCaptchaServiceTest
    {
        [Test]
        public void KataCaptchaService_ShouldNotReturnnullableCaptcha_WhencallGetCaptchaMethod() {
            KataCaptchaService captchaService = new KataCaptchaService();
            captchaService.SetRandomCaptcha(new RandomCaptchaProperty());
            var captcha = captchaService.GetCaptcha();
            Assert.AreNotEqual(null, captcha);
        }

        [Test]
        public void KataCaptchaTextInResultService_ShouldNotReturnEmptyString_WhencallGetCaptchaMethod()
        {
            KataCaptchaService captchaService = new KataCaptchaService();
            captchaService.SetRandomCaptcha(new RandomCaptchaProperty());
            var captcha = captchaService.GetCaptcha();
            Assert.AreNotEqual(String.Empty, captcha.ToString());
        }

        [Test]
        public void KataCaptchaTextInResultService_ShouldONEPlus1_WhenLeftOperandIs1OperatorIs1RightOperandIs1PatternIs1() {
            KataCaptchaService captchaService = new KataCaptchaService();
            var RandomStub =  Substitute.For<IRandom>();
            RandomStub.RandomOperand().Returns(1);
            RandomStub.RandomPattern().Returns(1);
            RandomStub.RandomOperator().Returns(1);
            captchaService.SetRandomCaptcha(RandomStub);
            Assert.AreEqual("ONE + 1", captchaService.GetCaptcha().ToString());
        }
    }
}
