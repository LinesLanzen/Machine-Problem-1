using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Machine_Problem_1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> studentList = new List<Student>
        {
            new Student
            {
                Id= 1,
                FirstName = "Killua",
                LastName = "Zoldy",
                PrelimGrade = 92,
                FinalGrade = 90
            },
            new Student
            {
                Id= 2,
                FirstName = "Jhin",
                LastName = "Dela Monte",
                PrelimGrade = 85,
                FinalGrade = 88
            },
            new Student
            {
                Id= 3,
                FirstName = "Dodie",
                LastName = "Dorotea",
                PrelimGrade = 78,
                FinalGrade = 82
            }
        };

        public IActionResult Index()
        {
            return View(studentList);
        }

        public IActionResult ShowDetails(int id)
        {
            Student student = studentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
            {
                return View(student);
            }

            return NotFound();
        }
    }
}
