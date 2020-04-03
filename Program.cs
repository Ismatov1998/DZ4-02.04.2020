using System;

namespace Student
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student("Anvar", "Hafizov","Abduloevich",21,"Tajik");
            
        }
    }
    class Student
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public int  age { get; set; }  
        public string nationality { get; set; }
           
    }
}
