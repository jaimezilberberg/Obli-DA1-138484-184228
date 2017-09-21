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
            Student student = new Student();
            student.StudentNumber = 1;
            student.ID = 1;

            Assert.AreEqual("a",student.Name);
            Assert.AreEqual("a",student.Surname);
            Assert.AreEqual(1, student.StudentNumber);
            Assert.AreEqual(1, student.ID);
        }
    }
}
