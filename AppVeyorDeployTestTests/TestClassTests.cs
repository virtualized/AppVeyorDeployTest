using AppVeyorDeployTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppVeyorDeployTestTests
{
    [TestClass]
    public class TestClassTests
    {
        [TestMethod]
        public void GetSomeStringTests()
        {
            var testClass = new TestClass();
            Assert.AreEqual("SomeString", testClass.GetSomeString());
        }
    }
}
