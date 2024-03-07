using laba1;

namespace TestLaba1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethodToString()
        {
            MyRational[] tests = {new(1, 2), new(6, 10), new(10, 5), new(6, -2), new(-3, 7),new(3,-9)};
            string[] results = { "1/2", "3/5", "2", "-3", "-3/7", "-1/3" };
            for(int i = 0;i < tests.Length; i++)
            {
                Assert.AreEqual(tests[i].ToString(), results[i], $"Неправильный вывод, завален {i+1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorPlus() {
            MyRational[] tests1 = { new(1, 2), new(6, 10), new(-10, 5),new(1,1),new(0,-45)};
            MyRational[] tests2 = { new(3, 4), new(4, 10), new(34, 25),new(2,2),new(4,2)};
            string[] results = { "5/4", "1", "-16/25", "2", "2" };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual((tests1[i] + tests2[i]).ToString(), results[i], $"Неправильный счёт +, завален {i+1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorMinus()
        {
            MyRational[] tests1 = { new(1, 2), new(6, 10), new(-1, 5), new(1, 1), new(0, -45) };
            MyRational[] tests2 = { new(3, 4), new(1, 15), new(34, 25), new(1, 36), new(4, 2) };
            string[] results = { "-1/4", "8/15", "-39/25", "35/36", "-2" };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual((tests1[i] - tests2[i]).ToString(), results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorMult()
        {
            MyRational[] tests1 = { new(1, 2), new(-6, -10), new(-1, 5), new(-1, 1), new(0, -45) };
            MyRational[] tests2 = { new(3, 4), new(1, 15), new(34, 25), new(1, -36), new(4, 2) };
            string[] results = { "3/8", "1/25", "-34/125", "1/36", "0" };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual((tests1[i] * tests2[i]).ToString(), results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorDiv()
        {
            MyRational[] tests1 = { new(1, 2), new(-6, -10), new(-1, 5), new(-1, 1), new(0, -45) };
            MyRational[] tests2 = { new(3, 4), new(1, 15), new(34, 25), new(1, -36), new(4, 2) };
            string[] results = { "2/3", "9", "-5/34", "36", "0" };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual((tests1[i] / tests2[i]).ToString(), results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorUnarMinus()
        {
            MyRational[] tests = { new(1, 2), new(6, -10),new(-4,-2) };
            string[] results = { "-1/2", "3/5", "-2"};
            for (int i = 0; i < tests.Length; i++)
            {
                Assert.AreEqual((-tests[i]).ToString(), results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorEq()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(-4, -2), new(4,34) };
            MyRational[] tests2 = { new(2, 4), new(-6, 10), new(-8, -4),new(5,22) };
            bool [] results = { true, true, true,false};
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] == tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorUnEq()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(-4, -2), new(4, 34) };
            MyRational[] tests2 = { new(2, 4), new(-6, 10), new(-8, -4), new(5, 22) };
            bool[] results = { false, false, false, true };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] != tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorMore()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(32, 2), new(4, 34) };
            MyRational[] tests2 = { new(2, 4), new(6, 10), new(8, 4), new(1, 57) };
            bool[] results = { false, false, true, true };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] > tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorMoreEq()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(32, 2), new(4, 34) };
            MyRational[] tests2 = { new(2, 4), new(6, 10), new(8, 4), new(1, 57) };
            bool[] results = { true, false, true, true };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] >= tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorLess()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(32, 2), new(4, 34) };
            MyRational[] tests2 = { new(2, 4), new(6, 10), new(8, 4), new(4, 34) };
            bool[] results = { false, true, false, false };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] < tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
        [Test]
        public void TestMethodOperatorLessEqq()
        {
            MyRational[] tests1 = { new(1, 2), new(6, -10), new(32, 2), new(4, 34) };
            MyRational[] tests2 = { new(2, 4), new(6, 10), new(8, 4), new(4, 34) };
            bool[] results = { true, true, false, true };
            for (int i = 0; i < tests1.Length; i++)
            {
                Assert.AreEqual(tests1[i] <= tests2[i], results[i], $"Неправильный счёт +, завален {i + 1} тест");
            }
        }
    }
}