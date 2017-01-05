using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBCL
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fb = new FizzBuzz();

        [Test]
        public void TestDivideByThree()
        {
            Assert.That(fb.DivideByThree(3));
        }
        [Test]
        public void TestDivideByFive()
        {
            Assert.That(fb.DivideByFive(5));
        }
        [Test]
        public void TestDivideByThreeAndFive()
        {
            Assert.That(fb.DivideByThreeAndFive(15));
        }

        [Test]
        public void TestEvaluate()
        {
            for (int i = 0; i < 100; i++)
            {
                var result = fb.Evaluate(i);
                if (result == "Fizz" || result == "Buzz" || result == "FizzBuzz")
                { Assert.Pass(); }
                else
                    Assert.Fail();
            }
        }
    }
}
