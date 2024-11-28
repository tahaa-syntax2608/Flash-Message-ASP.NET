using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitFeedback(string feedback)
        {
            // Store success message in TempData
            TempData["SuccessMessage"] = "Thank you for your feedback!";

            // Redirect to the confirmation page
            return RedirectToAction("Confirmation");
        }

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
