using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }

    public record Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string first, string last, string sub)
            : base(first, last) => Subject = sub;
    }

    public sealed record Student : Person
    {
        public int Level { get; }

        public Student(string first, string last, int level) : base(first, last) => Level = level;
    }

    class Records
    {
        public void Tryouts()
        {
                var person = new Person("Bill", "Wagner");
                var student = new Student("Bill", "Wagner", 11);

                Console.WriteLine(student == person); // false
        }
    }
}
