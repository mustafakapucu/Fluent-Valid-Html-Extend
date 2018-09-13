using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluent_Valid_Html_Extend.Models
{
    public class Employee_Validation : AbstractValidator<Employee>
    {
        public Employee_Validation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan gerekli.");
            RuleFor(x => x.Mail_ID).NotEmpty().WithMessage("Bu alan gerekli.");
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Bu alan gerekli.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu alan gerekli.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu alan gerekli.");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Şifreler Eşleşmiyor.");

            // bu kısım post olur sonra çalışır
            RuleFor(x => x.Mail_ID).EmailAddress().WithMessage("Email adres yanlış formatta.");
            RuleFor(x => x.DOB).Must(Validate_Age).WithMessage("18 den büyük olmalısınız.");
            RuleFor(x => x.Password).Must(Password_Lengh).WithMessage("Password 8 en büyük olmalı.");

        }

        private bool Password_Lengh(string pass_)
        {
            if (pass_.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool Validate_Age(DateTime Age_)
        {
            DateTime Current = DateTime.Today;
            int age = Current.Year - Convert.ToDateTime(Age_).Year;

            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}