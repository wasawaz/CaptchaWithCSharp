

using Kata_Captcha;
using NUnit.Framework;
namespace CaptchaTest
{

    [TestFixture]
    public class RandomTest
    {
        RandomCaptchaProperty random;

        [TestFixtureSetUp] 
        public void initialTestDependency()
        {
            random = new RandomCaptchaProperty();
        }

        [Test]
        public void RandomPattern_ShouldBe1_or_2_WhenInputRangeIsOneToTwo()
        {
            Assert.That(random.RandomPattern(), Is.InRange(1, 2));
        }


        [Test]
        public void RandomOperand_ShouldBe1_to_9_WhenInputRangeIsOneToNine()
        {
            Assert.That(random.RandomOperand(), Is.InRange(1, 9));
        }


        [Test]
        public void RandomOperator_Should1_to_3_WhenInputRangeIsOnetoThree()
        {
            Assert.That(random.RandomOperator(), Is.InRange(1, 3));
        }


    }
}
