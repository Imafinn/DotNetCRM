using DataModels.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Helper;

namespace NUnit.Tests.WebClient.Repositories
{
    [TestFixture]
    public class EmployeeRepositoryFakeTest
    {
        EmployeeRepositoryFake repo;

        [SetUp]
        public void Setup()
        {
            repo = new EmployeeRepositoryFake();
        }

        [Test]
        public void TestMethod()
        {
            Assert.AreNotEqual(repo.GetById(1).GetType(), new Employee().GetType());
        }
    }
}
