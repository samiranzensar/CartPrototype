using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithoutAuthentication.Models;

namespace MVCWithoutAuthentication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            DeptEmpDbContext dbContext = new DeptEmpDbContext();
            
            return View(dbContext.Employees);
        }
    }
}