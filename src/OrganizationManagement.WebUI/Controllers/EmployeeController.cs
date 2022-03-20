using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.FindAll();
            return View(employees);
        }
    }
}