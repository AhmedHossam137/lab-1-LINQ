using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        #region query1
        // query 1
        List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

        var query1 = numbers.Distinct().OrderBy(n => n);

        Console.WriteLine("Numbers without duplicates and sorted:");
        //foreach (var num in query1)
        //{
        //    Console.Write(num + " ");
        //}
        #endregion
        #region query2
        //query 2
        var query2 = query1.Select(n => new { Number = n, Multiplication = n * n });

        //foreach (var item in query2)
        //{
        //    Console.WriteLine($"Number: {item.Number}, Multiplication: {item.Multiplication}");
        //}
        #endregion
        #region query3
        // query 3
        string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

        var query3 = names.Where(name => name.Length == 3);

        Console.WriteLine("Names with length equal to 3:");
        //foreach (var name in query3)
        //{
        //    Console.WriteLine(name);
        //}
#endregion
        #region query 4
        //query 4
        var query4 = names
            .Where(name => name.IndexOf("a", StringComparison.OrdinalIgnoreCase) >= 0)
            .OrderBy(name => name.Length);
        //foreach (var name in query4)
        //{
        //    Console.WriteLine(name);
        //}
        #endregion 
        #region query 5
        //query 5
        var query5 = names.Take(2);

        //foreach (var name in query5)
        //{
        //    Console.WriteLine(name);
        //}
        #endregion
        #region query 6

        List<Student> students = new List<Student>()
        {
            new Student()
            {
                ID = 1,
                FirstName = "Ali",
                LastName = "Mohammed",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 33, Name = "UML" }
                }
            },
            new Student()
            {
                ID = 2,
                FirstName = "Mona",
                LastName = "Gala",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 34, Name = "XML" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 3,
                FirstName = "Yara",
                LastName = "Yousf",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 22, Name = "EF" },
                    new Subject() { Code = 25, Name = "JS" }
                }
            },
            new Student()
            {
                ID = 4, 
                FirstName = "Ali",
                LastName = "Ali",
                Subjects = new Subject[]
                {
                    new Subject() { Code = 33, Name = "UML" }
                }
            }
        };
        var query6 = students.Select(student => new
        {
            FullName = student.FirstName + " " + student.LastName,
            SubjectCount = student.Subjects.Length
        });

        // Display the results
        //foreach (var result in query6)
        //{
        //    Console.WriteLine($"Full Name: {result.FullName}, Number of Subjects: {result.SubjectCount}");
        //}
        #endregion
        #region query7
        var query7 = students
           .OrderByDescending(student => student.FirstName)  // Sort by FirstName Descending
           .ThenBy(student => student.LastName)  // Then sort by LastName Ascending
           .Select(student => new
           {
               student.FirstName,
               student.LastName
           });

       
        foreach (var student in query7)
        {
            Console.WriteLine($"First Name: {student.FirstName}, Last Name: {student.LastName}");
        }
        #endregion
    }
    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    // Define the Student class
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }
    }
}
