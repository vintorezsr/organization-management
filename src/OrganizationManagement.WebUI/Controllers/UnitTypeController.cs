using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class UnitTypeController : Controller
    {
        private readonly UnitTypeService _unitTypeService;

        public UnitTypeController(UnitTypeService unitTypeService)
        {
            _unitTypeService = unitTypeService;
        }

        public IActionResult Index()
        {
            var unitTypes = _unitTypeService.FindAll();
            return View(unitTypes);
        }
    }
}