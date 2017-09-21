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

            Assert.AreEqual("",student.Name);
            Assert.AreEqual("",student.Surname);
            Assert.AreEqual(1, student.StudentNumber);
            Assert.AreEqual(1, student.ID);
        }

        [TestMethod]
        public void TestMethodStudentWithParameters()
        {
            Student student = new Student("Enzo","Perez",123,456);
           

            Assert.AreEqual("Enzo", student.Name);
            Assert.AreEqual("Perez", student.Surname);
            Assert.AreEqual(123, student.StudentNumber);
            Assert.AreEqual(456, student.ID);
        }
    }
}
