using System;

namespace InherenceConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ali", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Aniq", 25, "1312", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("reza", 19, "2877", "27@amikom.ac.id");
            students.GetNameAndAge();
            
        }
    }
}
