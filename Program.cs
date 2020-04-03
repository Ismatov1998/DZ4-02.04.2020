using System;

namespace Student
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student("Anvar", "Hafizov","Abduloevich",21,"Tajik");
            student.Info();
        }
    }
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public int  age { get; set; }  
        public string nationality { get; set; }
            public Student(string name, string surname, string middleName, int age, string nationality)
        {
            this.name = name;
            this.surname = surname;
            this.middleName = middleName;
            this.age=age;
            this.nationality=nationality;

        }
        public void Info()
        {
            Console.WriteLine($" name {name}, surname {surname}, middlename {middleName}, age {age}, nationality {nationality}");
            
        }
    }
}
