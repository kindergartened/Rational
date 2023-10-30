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
        public void SumBig()
        {
            string n1 = "111111111111111111111111145454567";
            string n2 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 + num2;
            Assert.AreEqual(TestAddBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void SubBig()
        {
            string n2 = "111111111111111111111111145454567";
            string n1 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 - num2;
            Assert.AreEqual(TestMinusBig(n1, n2), result.ToString());
        }
        [TestMethod]
        public void DivBig()
        {
            string n2 = "111111111111111111111111145454567";
            string n1 = "885495849589458945849584958489588";
            BigInt num1 = new BigInt(n1);
            BigInt num2 = new BigInt(n2);
            BigInt result = num1 / num2;
            Assert.AreEqual(TestDivideBig(n1, n2), result.ToString());
        }
    }
}