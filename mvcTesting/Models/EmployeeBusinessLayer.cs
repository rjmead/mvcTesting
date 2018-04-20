using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcTesting.DataAccessLayer;

namespace mvcTesting.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
    }
}