using Fluent_Valid_Html_Extend.HtmlExtension;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluent_Valid_Html_Extend.Models
{
    [Validator(typeof(Employee_Validation))]
    public class Employee
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Mail_ID { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}