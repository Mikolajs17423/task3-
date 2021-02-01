using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using task3.Models;
using task3.DAL;

namespace task3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IDbService _dbService; 

        public StudentsController(IDbService dbService)
        {
            this._dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy) //action method
        {
            return Ok(_dbService.GetStudents());
        }


        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) //action method
        {
            if (id == 1)
            {
                return Ok("Jan");
            }
            else if (id == 2)
            {
                return Ok("Katarzyna");
            }
          /*  else if ( id ==3)
            {
                return Ok("Jasiu");
            }
          */
            return NotFound("Student was not found");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateStudent(string id)
        {
            return Ok("Update complete");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(string id)
        {
            return Ok("Delete completed");
        }


 

    }
}