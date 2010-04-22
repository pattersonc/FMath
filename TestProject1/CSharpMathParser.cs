using FMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class CSharpMathParserTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(15, CSharpMathParser.Parse<int>("5+5+5+5-5"));
        }
    }
}