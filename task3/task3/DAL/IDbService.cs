using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task3.Models;

namespace task3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
