using Microsoft.AspNetCore.Mvc;

namespace InsuranceRiskAssessment.Web.Controllers
{
    public class RealEstatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
