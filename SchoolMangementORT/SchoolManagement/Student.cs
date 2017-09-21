using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student:Person
    {
        public int StudentNumber { get; set; }
        public int ID { get; set; }

        public Student() : base()
        {
            this.StudentNumber = 1;
            this.ID = 1;
        }


    }
}
