using Crm.BusinessLayer.Abstract;
using Crm.BusinessLayer.Concrete;
using Crm.BusinessLayer.ValidationRules;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.EntityFramework;
using Crm.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Crm.UILayer.Controllers
{
    public class EmployeeController : Controller
    {
        //EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var values = _employeeService.TGetListAll();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            ValidationResult result = validationRules.Validate(employee);
            if(result.IsValid)
            {

                _employeeService.TInsert(employee);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
