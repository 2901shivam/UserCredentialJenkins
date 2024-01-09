using SignInLib;

namespace TestProjectOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult,SignIn.Authenticate("sam","sam@1256"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user credential";
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi","raj@123"));
        }

        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You must provide username and password"; 
            Assert.AreEqual(expResult, SignIn.Authenticate(null,null));
        }
    }
}