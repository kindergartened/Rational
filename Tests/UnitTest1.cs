     using Lib;
using static Lib.BigInt;
using static Lib.Utils;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyTest()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 * num2;
            Assert.AreEqual(TestMultiplyBig(n1,n2), result.ToString());
        }
        [TestMethod]
        public void MultiplyTest1()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 * num2;
            Assert.AreEqual(TestMultiplyBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void MultiplyTest2()
        {
            string n1 = "1";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 * num2;
            Assert.AreEqual(TestMultiplyBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void MultiplyTest3()
        {
            string n1 = "-1";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 * num2;
            Assert.AreEqual(TestMultiplyBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SumBigTest()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 + num2;
            Assert.AreEqual(TestAddBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SumBigTest1()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 + num2;
            Assert.AreEqual(TestAddBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SumBigTest2()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "-1";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 + num2;
            Assert.AreEqual(TestAddBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SubBigTest()
        {
            string n2 = "885495849589458945849584958489588";
            string n1 = "111111111111111111111111145454567";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 - num2;
            Assert.AreEqual(TestMinusBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SubBigTest1()
        {
            string n2 = "111111111111111111111111145454567";
            string n1 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 - num2;
            Assert.AreEqual(TestMinusBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SubBigTest2()
        {
            string n2 = "111111111111111111111111145454567";
            string n1 = "111111111111111111111111145454567";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 - num2;
            Assert.AreEqual(TestMinusBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SubBigTest3()
        {
            string n2 = "111111111111111111111111145454567";
            string n1 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 - num2;
            Assert.AreEqual(TestMinusBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBigTest()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "111111111111111111111111145454567";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBigTest1()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBigTest2()
        {
            string n1 = "0";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBigTest3()
        {
            string n1 = "885495849589458945849584958489588";
            string n2 = "1";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBigTest4()
        {
            string n1 = "885495849589458945849584958489588";
            string n2 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void OstBigTest1()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 % num2;
            Assert.AreEqual(TestOstBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void OstBigTest2()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "111111111111111111111111145454567";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 % num2;
            Assert.AreEqual(TestOstBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void OstBigTest3()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "1";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 % num2;
            Assert.AreEqual(TestOstBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void OstBigTest4()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 % num2;
            Assert.AreEqual(TestOstBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void OstBigTest5()
        {
            string n1 = "0";
            string n2 = "111111111111111111111111145454567";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 % num2;
            Assert.AreEqual(TestOstBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void PowBigTest1()
        {
            string n1 = "1234567891234567891234689";
            string n2 = "756";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 ^ num2;
            Assert.AreEqual(TestPowBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void PowBigTest2()
        {
            string n1 = "1234567891234567891234689";
            string n2 = "1";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 ^ num2;
            Assert.AreEqual(TestPowBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void PowBigTest3()
        {
            string n1 = "1234567891234567891234689";
            string n2 = "0";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 ^ num2;
            Assert.AreEqual(TestPowBig(n1, n2), result.ToString());
        }
    }
}