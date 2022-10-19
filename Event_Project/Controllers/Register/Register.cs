using Event_Project.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Event_Project.Controllers.Register
{
    public class Register : Controller
    {
        private readonly RequestHelper requestHelper;
        public Register(RequestHelper requestHelper)
        {
            this.requestHelper = requestHelper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(RegisterView model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new Users
            {
                EmailAddress = model.EmailAddress,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName
            };
            var request = requestHelper.Action("user", ActionType.Post, user);
            if (request.Result.Success == false)
            {
                ModelState.AddModelError("", "There is such an e-mail address registered in the system");
                return View(model);
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public IActionResult Company()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Company(CompanyView model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var company = new Company
            {
                EmailAdress = model.EmailAddress,
                Password = model.Password,
                CompanyName = model.CompanyName,
                
            };
            var request = requestHelper.Action("entegrator", ActionType.Post, company);
            if (request.Result.Success == false)
            {
                ModelState.AddModelError("", "There is such an e-mail address registered in the system");
                return View(model);
            }
            return RedirectToAction("Index", "Login");
        }

    }
}

