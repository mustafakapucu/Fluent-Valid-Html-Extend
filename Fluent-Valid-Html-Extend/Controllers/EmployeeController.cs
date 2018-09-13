using Fluent_Valid_Html_Extend.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluent_Valid_Html_Extend.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.Name = "Mustafa";
            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employee model)
        {
            Employee_Validation obj = new Employee_Validation();
            ValidationResult result = obj.Validate(model);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(model);
        }
    }
}