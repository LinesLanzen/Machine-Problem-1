using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Machine_Problem_1.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> employeeList = new List<Employee>
        {
            new Employee
            {
                FirstName = "Gabriel",
                LastName = "Montano",
                Birthday = DateTime.Parse("1993-09-17"),
                IsTenured = false,
                SalaryPerHour = 8.0,
                Email = "gdmontano@ust.edu.ph"
            },
            // Add more employees as needed
        };

        public IActionResult Index()
        {
            return View(employeeList);
        }

        public IActionResult ShowDetails()
        {
            // Assuming you want to display details of a specific employee here
            // You can pass the employee details to this action
            Employee employee = employeeList[0]; // Replace with the desired employee
            return View(employee);
        }
    }
}
