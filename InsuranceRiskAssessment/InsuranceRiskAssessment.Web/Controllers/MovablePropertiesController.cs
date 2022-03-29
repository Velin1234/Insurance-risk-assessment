using Microsoft.AspNetCore.Mvc;

namespace InsuranceRiskAssessment.Web.Controllers
{
    public class MovablePropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
