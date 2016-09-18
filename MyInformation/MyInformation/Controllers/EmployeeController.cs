using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyInformation.Models;
using MyInformation.Repository;

namespace MyInformation.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee Emp)
        {
            try
            {
                
                    EmpRepository EmpRepo = new EmpRepository();

                    if (EmpRepo.AddEmp(Emp))
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                

                return View();
            }
            catch
            {
                return View();
            }    
        }    

    }
}
