using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3.Models;

namespace task3.DAL
{
    public class MockDbService : IDbService

    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
      new Student{IdStudent = 1, FirstName = "Jasiu", LastName = "Kubek", IndexNumber = "s11111"},
       new Student{IdStudent = 2, FirstName = "Weronika", LastName = "Laptop", IndexNumber = "s22222"},
       new Student{IdStudent = 3, FirstName = "Stasiu", LastName = "Monitor", IndexNumber = "s33333"}
            };

        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}