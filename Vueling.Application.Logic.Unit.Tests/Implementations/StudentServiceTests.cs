using Autofac.Extras.Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vueling.Application.Logic.Contracts;
using Vueling.Domain.Entities;

namespace Vueling.Application.Logic.Implementations.Unit.Tests
{
    [TestClass()]
    public class StudentServiceTests
    {
        

        [TestMethod()]
        public void CreateTest()
        {
            using(var mock = AutoMock.GetLoose())
            {
                //Arrange
                
                Student student1 = new Student { Id = 1, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

                mock.Mock<IService<Student>>().Setup(service => service.Create(student1)).Returns(student1);
                var sut = mock.Create<IService<Student>>();

                //Action
                var actual = sut.Create(student1);

                //Assert
                mock.Mock<IService<Student>>().Verify(service => service.Create(student1));
                Assert.IsTrue(actual.Equals(student1));
            }
        }

        [TestMethod()]
        public void DeleteTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange

                Student student1 = new Student { Id = 1, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

                mock.Mock<IService<Student>>().Setup(service => service.Delete(student1.Id)).Returns(true);
                var sut = mock.Create<IService<Student>>();

                //Action
                var actual = sut.Delete(student1.Id);

                //Assert
                mock.Mock<IService<Student>>().Verify(service => service.Delete(student1.Id));
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

                Student student1 = new Student { Id = 1, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

                Student student2 = new Student { Id = 3, Name = "sdf", Lastname = "bnvc", BirthDate = DateTime.Parse("10/10/200") };

                studentsList.Add(student1);
                studentsList.Add(student2);

                mock.Mock<IService<Student>>().Setup(service => service.GetAll()).Returns(studentsList);
                var sut = mock.Create<IService<Student>>();

                //Action
                var actual = sut.GetAll();

                //Assert
                mock.Mock<IService<Student>>().Verify(service => service.GetAll());
                Assert.AreEqual(actual, studentsList);
            }
        }

        [TestMethod()]
        public void UpdateTest()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange

                Student student1 = new Student { Id = 1, Name = "raul", Lastname = "segui", BirthDate = DateTime.Parse("10/10/200") };

                mock.Mock<IService<Student>>().Setup(service => service.Update(student1)).Returns(student1);
                var sut = mock.Create<IService<Student>>();

                //Action
                var actual = sut.Update(student1);

                //Assert
                mock.Mock<IService<Student>>().Verify(service => service.Update(student1));
                Assert.IsTrue(actual.Equals(student1));
            }
        }
    }
}