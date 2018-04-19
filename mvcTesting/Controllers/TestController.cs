using mvcTesting.Models;
using mvcTesting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcTesting.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "sup frick sweet";
        }
        
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Bob";
            emp.LastName = "Mead";
            emp.Salary = 100000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if(emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            //testpush

            vmEmp.UserName = "Admin";

            return View("MyView", vmEmp);
        }
    }
}