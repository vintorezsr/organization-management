using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class JobFamilyController : Controller
    {
        private readonly JobFamilyService _jobFamilyService;

        public JobFamilyController(JobFamilyService jobFamilyService)
        {
            _jobFamilyService = jobFamilyService;
        }

        public IActionResult Index()
        {
            var jobFamilies = _jobFamilyService.FindAll();
            return View(jobFamilies);
        }
    }
}