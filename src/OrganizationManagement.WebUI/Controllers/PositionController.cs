using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class PositionController : Controller
    {
        private readonly PositionService _positionService;

        public PositionController(PositionService positionService)
        {
            _positionService = positionService;
        }

        public IActionResult Index()
        {
            var positions = _positionService.FindAll();
            return View(positions);
        }
    }
}