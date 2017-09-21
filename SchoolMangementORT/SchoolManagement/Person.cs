namespace SchoolManagement
{
    public class Person
    {
        public string Name{ get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Name = "";
            Surname = "";
        }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}