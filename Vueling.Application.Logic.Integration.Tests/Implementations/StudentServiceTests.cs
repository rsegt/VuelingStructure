using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vueling.Application.Logic.AutofacModules;
using Vueling.Test.Framework;

namespace Vueling.Application.Logic.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentServiceTests : IoCSupportedTest<ApplicationModule>
    {

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}