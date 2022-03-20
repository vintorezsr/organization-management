using Microsoft.AspNetCore.Mvc;
using OrganizationManagement.WebUI.Services;

namespace OrganizationManagement.WebUI.Controllers
{
    public class JobController : Controller
    {
        private readonly JobService _jobService;

        public JobController(JobService jobService)
        {
            _jobService = jobService;
        }

        public IActionResult Index()
        {
            var jobs = _jobService.FindAll();
            return View(jobs);
        }
    }
}