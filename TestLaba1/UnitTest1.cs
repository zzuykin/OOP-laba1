using laba1;

namespace TestLaba1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1,0)]
        [TestCase(0,0)]
        [TestCase(-5,0)]
        public void TestException(int a,int b)
        {
            Assert.Throws<ArgumentException>(() => new MyRational(a, b));
        }

        [Test]
        [TestCase(1, 2, "1/2")]
        [TestCase(6, 10, "3/5")]
        [TestCase(10, 5, "2")]
        [TestCase(6, -2, "-3")]
        public void TestMethodToString(int a1, int a2, string result)
        {
            var a = new MyRational(a1, a2);
            Assert.That(a.ToString() == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 5, 4)]
        [TestCase(6, 10, 4, 10, 1, 1)]
        [TestCase(-10, 5, 34, 25, -16, 25)]
        [TestCase(1, 1, 2, 2, 2, 1)]
        [TestCase(0, -45, 4, 2, 2, 1)]
        public void TestMethodOperatorPlus(int a1, int a2, int b1, int b2, int r1, int r2) {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);

            var result = a + b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, -1, 4)]
        [TestCase(6,10, 1, 15, 8, 15)]
        [TestCase(-1, 5, 34, 25, -39, 25)]
        [TestCase(1, 1, 1, 36, 35, 36)]
        [TestCase(0, -45, 4, 2, 2, -1)]
        public void TestMethodOperatorMinus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);

            var result = a - b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 3, 8)]
        [TestCase(-6, -10, 1, 15, 1, 25)]
        [TestCase(-1, 5, 34, 25, -34, 125)]
        [TestCase(-1, 1, 1, -36, 1, 36)]
        [TestCase(0, -45, 4, 2, 0, -45)]
        public void TestMethodOperatorMult(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);

            var result = a * b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 2, 3)]
        [TestCase(-6, -10,1,15, 9, 1)]
        [TestCase(-1, 5, 34, 25, -5, 34)]
        [TestCase(-1, 1, 1, -36, 36, 1)]
        [TestCase(0, -45, 4, 2, 0, -90)]
        public void TestMethodOperatorDiv(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);

            var result = a / b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, -1, 2)]
        [TestCase(6, -10, 3, 5)]
        [TestCase(-4, -2, -2, 1)]
        public void TestMethodOperatorUnarMinus(int a1, int a2,int r1, int r2)
        {
            var a = new MyRational(a1, a2);

            var result = -a;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2,4,true)]
        [TestCase(6, -10, -6,10,true)]
        [TestCase(-4, -2, -8,-4,true)]
        [TestCase(4, 34, 5,22,false)]
        public void TestMethodOperatorEq(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a == b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(6, -10, -6, 10, false)]
        [TestCase(-4, -2, -8, -4, false)]
        [TestCase(4, 34, 5, 22, true)]
        public void TestMethodOperatorUnEq(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a != b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(6, -10, 6, 10, false)]
        [TestCase(32, 2, 8, 4, true)]
        [TestCase(4, 34, 1, 57, true)]
        public void TestMethodOperatorMore(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a > b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(6, -10, 6, 10, false)]
        [TestCase(32, 2, 8, 4, true)]
        [TestCase(4, 34, 1, 57, true)]
        public void TestMethodOperatorMoreEq(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a >= b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(6, -10, 6, 10, true)]
        [TestCase(32, 2, 8, 4, false)]
        [TestCase(4, 34, 4, 34, false)]
        public void TestMethodOperatorLess(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a < b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(6, -10, 6, 10, true)]
        [TestCase(32, 2, 8, 4, false)]
        [TestCase(4, 34, 4, 34, true)]
        public void TestMethodOperatorLessEqq(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new MyRational(a1, a2);
            var b = new MyRational(b1, b2);
            Assert.That((a <= b) == result, Is.True);
        }
    }
}