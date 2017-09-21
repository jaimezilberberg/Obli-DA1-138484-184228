using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolManagement;
namespace UnitTestProjectSchoolManagement
{
    /// <summary>
    /// Descripción resumida de UnitTestPerson
    /// </summary>
    [TestClass]
    public class UnitTestPerson
    {
        public UnitTestPerson()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        
        [TestMethod]
        public void TestMethodConstructor()
        {
            Person person = new Person();
            person.Name = "";
            person.Surname = "";

           
            Assert.AreEqual("", person.Name);
            Assert.AreEqual("", person.Surname);
        }
    }
}
