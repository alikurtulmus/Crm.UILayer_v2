using Crm.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.ValidationRules
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            //Constractor oluşturduğumuz için ilgili sınıfa ait property'lere nesne üretmeye gerek kalmadan ulaşabiliyoruz.
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel adı boş geçilemez!");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel Soyadı boş geçilemez!");
            RuleFor(x => x.EmployeeMail).NotEmpty().WithMessage("Personel maili boş geçilemez!");
            RuleFor(x => x.EmployeePassword).NotEmpty().WithMessage("Personel şifresi boş geçilemez!");
            RuleFor(x => x.EmployeeGender).NotEmpty().WithMessage("Personel cinsiyeti boş geçilemez!");
            RuleFor(x => x.EmployeeBirth).NotEmpty().WithMessage("Personel doğum tarihi boş geçilemez!");
            RuleFor(x => x.EmployeePassword).MinimumLength(4).WithMessage("Personel şifresi en az 4 karakterden oluşmalı!");
        }
    }
}
