using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Form form)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
