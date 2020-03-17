using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;

namespace Vueling.Infrastructure.Repositories.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentRepositoryTests
    {

        [TestMethod()]
        public void CreateTest()
        {
            Student student = new Student { Id = 2, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IRepository<Student>>().Setup(repository => repository.Create(student)).Returns(student);
                var sut = mock.Create<IRepository<Student>>();


                var actual = sut.Create(student);

                Assert.AreEqual(actual, student);
            }
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Student student = new Student { Id = 2, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IRepository<Student>>().Setup(repository => repository.Delete(student.Id)).Returns(true);
                var sut = mock.Create<IRepository<Student>>();

                var actual = sut.Delete(student.Id);

                Assert.AreEqual(true, actual);
            }
        }

        [TestMethod()]
        public void GetAllTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                List<Student> studentsList = new List<Student>();

                Student student1 = new Student { Id = 2, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

                Student student2 = new Student { Id = 3, Name = "sdf", Lastname = "bnvc", BirthDate = DateTime.Parse("10/10/200") };

                studentsList.Add(student1);
                studentsList.Add(student2);

                mock.Mock<IRepository<Student>>().Setup(repository => repository.GetAll()).Returns(studentsList);
                var sut = mock.Create<IRepository<Student>>();

                //Act
                var actual = sut.GetAll();

                //Asert
                mock.Mock<IRepository<Student>>().Verify(repository => repository.GetAll());
                Assert.IsTrue(actual.Equals(studentsList));
            }
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Student student = new Student { Id = 2, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IRepository<Student>>().Setup(repository => repository.Update(student)).Returns(student);
                var sut = mock.Create<IRepository<Student>>();

                var actual = sut.Update(student);

                Assert.AreEqual(actual, student);
            }
        }
    }
}