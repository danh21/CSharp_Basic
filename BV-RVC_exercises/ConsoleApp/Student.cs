using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
        public class Student
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public int Age { get; init; }

            public Student(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }

        internal static class StudentQueries
        {
            public static IEnumerable<string> GetNamesAge18To24(IEnumerable<Student> students)
            {
                return students
                    .Where(s => s.Age >= 18 && s.Age <= 24)
                    .Select(s => $"{s.FirstName} {s.LastName}");
            }
        }
}
