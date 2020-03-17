using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;
using Vueling.Infrastructure.Repository.Integration.Tests.AutofacModules;
using Vueling.Test.Framework;

namespace Vueling.Infrastructure.Repositories.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentRepositoryTests : IoCSupportedTest<RepositoryModule>
    {

        private IRepository<Student> repository = null;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        [TestInitialize]
        public void SetUp()
        {
            repository = Resolve<IRepository<Student>>();
        }

        [TestMethod()]
        public void CreateTest()
        {
            Student studentToAdd = new Student { Name = "added", Lastname = "student", BirthDate = DateTime.Parse("10/10/2000") };
            var addedStudent = repository.Create(studentToAdd);

            Assert.AreEqual(studentToAdd, addedStudent);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<Student> studentsList = repository.GetAll();

            Assert.IsTrue(studentsList.Count > 0, "studentsList is 0 or null");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}