using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolManagement;
namespace UnitTestProjectSchoolManagement
{
    [TestClass]
    public class UnitTestStudent
    {
        [TestMethod]
        public void TestMethodStudent()
        {
            Person student = new Student();
            student.StudentNumber = 1;
            student.ID = 1;

            Assert.AreEqual("",student.Name);
            Assert.AreEqual("",student.Surname);
            Assert.Equals(1, student.StudentNumber);
            Assert.Equals(1, student.ID);
        }
    }
}
