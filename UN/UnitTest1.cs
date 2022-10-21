using Models;

namespace UN
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public static void Textoginuser()
        {
            bool result = Models.Cliente.loginuser("henry", "1234");
            Assert.AreEqual(true, result);
        }
        [TestClass]
        public class UnitTest2
        {
            [TestMethod]
            public void TestMethod3()
            {
                int a = 1000999999;
                bool result = Models.Cliente.login(a);
                Assert.AreEqual(true, result);
            }
            [TestMethod]
            public void TestMethod1()
            {
                var document = new Cliente();
                int nroDocumento = 1000999999;

                bool isValid = Cliente.login(nroDocumento);
                Assert.IsTrue(isValid);
            }
        }
    }
}
