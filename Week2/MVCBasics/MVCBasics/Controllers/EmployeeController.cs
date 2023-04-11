using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    //A controller is a C# class that inherits from Controller
    public class EmployeeController : Controller
    {
        //fields
        List<Employee> employees;
        //assign values to fields - Constructor
        //Special method that runs whenever an instance of our class is created
        public EmployeeController()
        { 
            employees = new List<Employee>();
            //the old way
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.FirstName = "Test";
            e1.LastName = "Name";
            e1.EmployeeId = "TN345780";
            e1.Phone = "1234567890";
            e1.Active = true;
            //add employee to the list
            employees.Add(e1);
            //How to make a new entity model
            Employee e2 = new Employee
            {
                Id = 2,
                FirstName = "Jerome",
                LastName = "Antiporda",
                EmployeeId = "JA569196",
                Phone = "2069740634",
                Active = true
            };
            employees.Add(e2);
        } 

        //lets add an endpoint
        //We hit this endpoint by going to host/Employee/Index
        //or host/Employee
        public IActionResult Index()
        {
            //Its going to look for a view in /Views/Employee/Index.cshtml
            //pass our list of employees to the view
            return View(employees);
        }
        //Details - It will sent one employee to a view
        //Details takes in an id and sends the employee that mathces the id
        //This endpoint is going to look for a view in Views/Employees/Details.cshtml
        public IActionResult Details(int id)
        {
            //loop through employees and find the matching employee
            foreach(Employee e in employees)
            {
                if(e.Id == id)
                {
                    return View(e);
                }
            }
            //if this loop ends and we did not find an employee
            //return NotFound();
            return NotFound();

        }
    }
}
