using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class OrganizationUnitController : Controller
    {
        private readonly OrganizationUnitService _organizationUnitService;

        public OrganizationUnitController(OrganizationUnitService organizationUnitService)
        {
            _organizationUnitService = organizationUnitService;
        }

        public IActionResult Index()
        {
            var organizationUnits = _organizationUnitService.FindAll();
            return View(organizationUnits);
        }
    }
}